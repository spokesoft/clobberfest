(function (root) {
  const isArray = (arr) => Object.prototype.toString.call(arr) == '[object Array]'
  const isNumber = (n) => typeof n === "number" && !isNaN(n);
  const slice = Array.prototype.slice;

  /*
  |----------------------------------------------------------------------------
  | Canvas class
  |----------------------------------------------------------------------------
  */

  class Canvas {
    constructor(element) {
      this.element = element;
      this.context = element.getContext("2d");
      this.width = element.width;
      this.height = element.height;
      this.pixelRatio = window.devicePixelRatio;
      this.clear();
    }

    clear() {
      this.context.clearRect(0, 0, this.width, this.height);
    }

    path(points, color) {
      this.context.beginPath();
      this.context.moveTo(points[0].x, points[0].y);
      for (var i = 1; i < points.length; i++) {
        this.context.lineTo(points[i].x, points[i].y);
      }
      this.context.closePath();
      this.context.save();
      this.context.globalAlpha = color.a;
      this.context.fillStyle = this.context.strokeStyle = color.hex;
      this.context.stroke();
      this.context.fill();
      this.context.restore();
    }
  }

  /*
  |----------------------------------------------------------------------------
  | Color class
  |----------------------------------------------------------------------------
  */

  function hue2rgb(p, q, t) {
    if (t < 0) t += 1;
    if (t > 1) t -= 1;
    if (t < 1 / 6) return p + (q - p) * 6 * t;
    if (t < 1 / 2) return q;
    if (t < 2 / 3) return p + (q - p) * (2 / 3 - t) * 6;
    return p;
  }

  class Color {
    constructor(r, g, b, a = 1) {
      this.r = parseInt(r || 0);
      this.g = parseInt(g || 0);
      this.b = parseInt(b || 0);
      this.a = parseFloat(Math.round(a * 100) / 100 || 1);

      r = this.r / 255;
      g = this.g / 255;
      b = this.b / 255;

      const max = Math.max(r, g, b);
      const min = Math.min(r, g, b);

      var h,
        s,
        l = (max + min) / 2;

      if (max === min) {
        h = s = 0;
      } else {
        var d = max - min;
        s = l > 0.5 ? d / (2 - max - min) : d / (max + min);
        switch (max) {
          case r:
            h = (g - b) / d + (g < b ? 6 : 0);
            break;
          case g:
            h = (b - r) / d + 2;
            break;
          case b:
            h = (r - g) / d + 4;
            break;
        }
        h /= 6;
      }

      this.h = h;
      this.s = s;
      this.l = l;
    }

    get hex() {
      const toHex = (color) => {
        const hex = color.toString(16);
        return hex.length === 1 ? "0" + hex : hex;
      };
    }

    lighten(percentage, lightColor) {
      lightColor = lightColor || new Color(255, 255, 255);

      var color = new Color(
        (lightColor.r / 255) * this.r,
        (lightColor.g / 255) * this.g,
        (lightColor.b / 255) * this.b,
        this.a
      );
    
      color.l = Math.min(lightColor.l + percentage, 1);
    
      color.loadRGB();
      return color;
    }

    loadHSL() {
      const r = this.r / 255;
      const g = this.g / 255;
      const b = this.b / 255;
    
      const max = Math.max(r, g, b);
      const min = Math.min(r, g, b);
    
      let h, s, l = (max + min) / 2;
    
      if (max === min) {
        h = s = 0;
      } else {
        const d = max - min;
        s = l > 0.5 ? d / (2 - max - min) : d / (max + min);
        switch (max) {
          case r: h = (g - b) / d + (g < b ? 6 : 0); break;
          case g: h = (b - r) / d + 2; break;
          case b: h = (r - g) / d + 4; break;
        }
    
        h /= 6;
      }
    
      this.h = h;
      this.s = s;
      this.l = l;
    }

    loadRGB() {
      let r, g, b;
      const h = this.h;
      const s = this.s;
      const l = this.l;
    
      if (s === 0) {
        r = g = b = l; 
      } else {
        var q = l < 0.5 ? l * (1 + s) : l + s - l * s;
        var p = 2 * l - q;
        r = hue2rgb(p, q, h + 1 / 3);
        g = hue2rgb(p, q, h);
        b = hue2rgb(p, q, h - 1 / 3);
      }
    
      this.r = parseInt(r * 255);
      this.g = parseInt(g * 255);
      this.b = parseInt(b * 255);
    }
  }

  /*
  |----------------------------------------------------------------------------
  | Path class
  |----------------------------------------------------------------------------
  */

  class Path {
    constructor(points) {
      if (Object.prototype.toString.call(points) === '[object Array]') {
        this.points = points;
      } else {
        this.points = Array.prototype.slice.call(arguments);
      }
    }

    get depth() {
      var i,
        total = 0;
      for (i = 0; i < this.points.length; i++) {
        total += this.points[i].depth();
      }
      return total / (this.points.length || 1);
    }

    push(point) {
      this.points.push(point);
    }

    reverse() {
      const points = this.points.slice();
      return new Path(points.reverse());
    }

    translate() {
      const args = arguments;
      return new Path(
        this.points.map((point) => point.translate.apply(point, args))
      );
    }

    rotateX() {
      const args = arguments;
      return new Path(
        this.points.map((point) => point.rotateX.apply(point, args))
      );
    }

    rotateY() {
      const args = arguments;
      return new Path(
        this.points.map((point) => point.rotateY.apply(point, args))
      );
    }

    rotateZ() {
      const args = arguments;
      return new Path(
        this.points.map((point) => point.rotateZ.apply(point, args))
      );
    }

    scale() {
      const args = arguments;
      return new Path(
        this.points.map((point) => point.scale.apply(point, args))
      );
    }
  }

  /*
  |----------------------------------------------------------------------------
  | Point class
  |----------------------------------------------------------------------------
  */

  class Point {
    static origin = new Point(0, 0, 0);

    static distance(p1, p2) {
      const dx = p2.x - p1.x;
      const dy = p2.y - p1.y;
      const dz = p2.z - p1.z;
      return Math.sqrt(dx * dx + dy * dy + dz * dz);
    }

    constructor(x, y, z) {
      this.x = isNumber(x) ? x : 0;
      this.y = isNumber(y) ? y : 0;
      this.z = isNumber(z) ? z : 0;
    }

    get depth() {
      return this.x + this.y - 2 * this.z;
    }

    translate(dx, dy, dz) {
      return new Point(this.x + dx, this.y + dy, this.z + dz);
    }

    scale(origin, dx, dy, dz) {
      const point = new Point(-origin.x, -origin.y, -origin.z);
      if (dy === undefined && dz === undefined) {
        dy = dz = dx;
      } else {
        dz = isNumber(dz) ? dz : 1;
      }
      point.x *= dx;
      point.y *= dy;
      point.z *= dz;
      return point.translate(origin.x, origin.y, origin.z);
    }

    rotate(axis, origin, angle) {
      switch (axis) {
        case "x":
          return this.rotateX(origin, angle);
        case "y":
          return this.rotateY(origin, angle);
        case "z":
          return this.rotateZ(origin, angle);
        default:
          throw new Error("Invalid axis");
      }
    }

    rotateX(origin, angle) {
      const point = this.translate(-origin.x, -origin.y, -origin.z);
      const z = point.z * Math.cos(angle) - point.y * Math.sin(angle);
      const y = point.z * Math.sin(angle) + point.y * Math.cos(angle);
      point.z = z;
      point.y = y;
      return point.translate(origin.x, origin.y, origin.z);
    }

    rotateY(origin, angle) {
      const point = this.translate(-origin.x, -origin.y, -origin.z);
      const x = point.x * Math.cos(angle) - point.z * Math.sin(angle);
      const z = point.x * Math.sin(angle) + point.z * Math.cos(angle);
      point.x = x;
      point.z = z;
      return p.translate(origin.x, origin.y, origin.z);
    }

    rotateZ(origin, angle) {
      const point = this.translate(-origin.x, -origin.y, -origin.z);
      const x = point.x * Math.cos(angle) - point.y * Math.sin(angle);
      const y = point.x * Math.sin(angle) + point.y * Math.cos(angle);
      point.x = x;
      point.y = y;
      return point.translate(origin.x, origin.y, origin.z);
    }
  }

  /*
  |----------------------------------------------------------------------------
  | Shape class
  |----------------------------------------------------------------------------
  */

  class Shape {
    constructor(...paths) {
      this.paths = paths;
    }

    push(point) {
      this.paths.push(point);
    }

    translate() {
      const args = arguments;
      return new Shape(
        this.paths.map((path) => path.translate.apply(path, args))
      );
    }

    rotateX() {
      const args = arguments;
      return new Shape(
        this.paths.map((path) => path.rotateX.apply(path, args))
      );
    }

    rotateY() {
      const args = arguments;
      return new Shape(
        this.paths.map((path) => path.rotateY.apply(path, args))
      );
    }

    rotateZ() {
      const args = arguments;
      return new Shape(
        this.paths.map((path) => path.rotateZ.apply(path, args))
      );
    }

    scale() {
      const args = arguments;
      return new Shape(this.paths.map((path) => path.scale.apply(path, args)));
    }

    orderPaths() {
      var paths = this.paths.slice();
      return paths.sort(function (a, b) {
        return b.depth - a.depth;
      });
    }
  }

  /*
  |----------------------------------------------------------------------------
  | Vector class
  |----------------------------------------------------------------------------
  */

  class Vector {
    static fromTwoPoints(p1, p2) {
      return new Vector(p2.x - p1.x, p2.y - p1.y, p2.z - p1.z);
    }

    static crossProduct(v1, v2) {
      return new Vector(
        v1.j * v2.k - v1.k * v2.j,
        v1.k * v2.i - v1.i * v2.k,
        v1.i * v2.j - v1.j * v2.i
      );
    }

    static dotProduct(v1, v2) {
      return v1.i * v2.i + v1.j * v2.j + v1.k * v2.k;
    }

    constructor(i, j, k) {
      this.i = isNumber(i) ? i : 0;
      this.j = isNumber(j) ? j : 0;
      this.k = isNumber(k) ? k : 0;
    }

    get magnitude() {
      return Math.sqrt(this.i * this.i + this.j * this.j + this.k * this.k);
    }

    normalize() {
      const magnitude = this.magnitude;
      if (magnitude === 0) {
        return new Vector(0, 0, 0);
      }
      return new Vector(
        this.i / magnitude,
        this.j / magnitude,
        this.k / magnitude
      );
    }
  }

  /*
  |----------------------------------------------------------------------------
  | Shapes
  |----------------------------------------------------------------------------
  */

  Path.Rectangle = (origin, width, height) => {
    if (width === undefined) width = 1;
    if (height === undefined) height = 1;

    var path = new Path([
      origin,
      new Point(origin.x + width, origin.y, origin.z),
      new Point(origin.x + width, origin.y + height, origin.z),
      new Point(origin.x, origin.y + height, origin.z),
    ]);

    return path;
  };

  Path.Rectangle = (origin, radius, vertices) => {
    vertices = vertices || 20;
    let i,
      path = new Path();

    for (i = 0; i < vertices; i++) {
      path.push(
        new Point(
          radius * Math.cos((i * 2 * Math.PI) / vertices),
          radius * Math.sin((i * 2 * Math.PI) / vertices),
          0
        )
      );
    }

    return path.translate(origin.x, origin.y, origin.z);
  };

  Path.Star = (origin, outerRadius, innerRadius, points) => {
    var i,
      r,
      path = new Path();

    for (i = 0; i < points * 2; i++) {
      r = i % 2 === 0 ? outerRadius : innerRadius;

      path.push(
        new Point(
          r * Math.cos((i * Math.PI) / points),
          r * Math.sin((i * Math.PI) / points),
          0
        )
      );
    }

    return path.translate(origin.x, origin.y, origin.z);
  };

  Shape.extrude = (path, height) => {
    height = typeof height === "number" ? height : 1;

    var i,
      topPath = path.translate(0, 0, height);
    var shape = new Shape();

    /* Push the top and bottom faces, top face must be oriented correctly */
    shape.push(path.reverse());
    shape.push(topPath);

    /* Push each side face */
    for (i = 0; i < path.points.length; i++) {
      shape.push(
        new Path([
          topPath.points[i],
          path.points[i],
          path.points[(i + 1) % path.points.length],
          topPath.points[(i + 1) % topPath.points.length],
        ])
      );
    }

    return shape;
  };

  Shape.Prism = (origin, dx, dy, dz) => {

    dx = typeof dx === "number" ? dx : 1;
    dy = typeof dy === "number" ? dy : 1;
    dz = typeof dz === "number" ? dz : 1;

    /* The shape we will return */
    var prism = new Shape();

    /* Squares parallel to the x-axis */
    var face1 = new Path([
      origin,
      new Point(origin.x + dx, origin.y, origin.z),
      new Point(origin.x + dx, origin.y, origin.z + dz),
      new Point(origin.x, origin.y, origin.z + dz),
    ]);

    /* Push this face and its opposite */
    prism.push(face1);
    prism.push(face1.reverse().translate(0, dy, 0));

    /* Square parallel to the y-axis */
    var face2 = new Path([
      origin,
      new Point(origin.x, origin.y, origin.z + dz),
      new Point(origin.x, origin.y + dy, origin.z + dz),
      new Point(origin.x, origin.y + dy, origin.z),
    ]);
    prism.push(face2);
    prism.push(face2.reverse().translate(dx, 0, 0));

    /* Square parallel to the xy-plane */
    var face3 = new Path([
      origin,
      new Point(origin.x + dx, origin.y, origin.z),
      new Point(origin.x + dx, origin.y + dy, origin.z),
      new Point(origin.x, origin.y + dy, origin.z),
    ]);
    /* This surface is oriented backwards, so we need to reverse the points */
    prism.push(face3.reverse());
    prism.push(face3.translate(0, 0, dz));

    return prism;
  };

  Shape.Pyramid = (origin, dx, dy, dz) => {
    dx = (typeof dx === 'number') ? dx : 1;
    dy = (typeof dy === 'number') ? dy : 1;
    dz = (typeof dz === 'number') ? dz : 1;
  
    var pyramid = new Shape();
  
    /* Path parallel to the x-axis */
    var face1 = new Path([
      origin,
      new Point(origin.x + dx, origin.y, origin.z),
      new Point(origin.x + dx / 2, origin.y + dy / 2, origin.z + dz)
    ]);
    /* Push the face, and its opposite face, by rotating around the Z-axis */
    pyramid.push(face1);
    pyramid.push(face1.rotateZ(origin.translate(dx / 2, dy / 2), Math.PI));
  
    /* Path parallel to the y-axis */
    var face2 = new Path([
      origin,
      new Point(origin.x + dx / 2, origin.y + dy / 2, origin.z + dz),
      new Point(origin.x, origin.y + dy, origin.z)
    ]);
    pyramid.push(face2);
    pyramid.push(face2.rotateZ(origin.translate(dx / 2, dy / 2), Math.PI));
  
    return pyramid;
  };

  Shape.Cylinder = (origin, radius, vertices, height) => {
    radius = (typeof radius === 'number') ? radius : 1;
  
    var circle = Path.Circle(origin, radius, vertices);
    var cylinder = Shape.extrude(circle, height);
  
    return cylinder;
  };

  /*
  |----------------------------------------------------------------------------
  | Scene class
  |----------------------------------------------------------------------------
  */
  
  class Scene {

    constructor(id, options) {
      options = options || {};
      this.canvas = new Canvas(document.getElementById(id));
      this.light = {};
      this.color = {};

      this.angle = Math.PI / 6;
      this.scale = options.scale || 70;
      this.transformation = [
        [
          this.scale * Math.cos(this.angle),
          this.scale * Math.sin(this.angle)
        ],
        [
          this.scale * Math.cos(Math.PI - this.angle),
          this.scale * Math.sin(Math.PI - this.angle)
        ]
      ];
      this.originX = options.originX || this.canvas.width / 2;
      this.originY = options.originY || this.canvas.height * 0.9;
      this.light.position = new Vector(2, -1, 3);
      this.light.angle = this.light.position.normalize();
      this.color.difference = 0.20;
      this.light.color = new Color(255, 255, 255);
    }

    add(items, color) {
      items = isArray(items) ? items : [items];
      for (var i = 0; i < items.length; i++) {
        var item = items[i];
        if (item instanceof Path) {
          this.addPath(item, color);
        } else if (item instanceof Shape) {
          for (var j = 0; j < item.paths.length; j++) {
            this.addPath(item.paths[j], color);
          }
        } else {
          console.error(`Invalid item type: ${typeof item}`);
        }
      }
    }

    addPath(path, baseColor) {
      baseColor = baseColor || new Color(120, 120, 120);

      /* Compute color */
      var v1 = Vector.fromTwoPoints(path.points[1], path.points[0]);
      var v2 = Vector.fromTwoPoints(path.points[2], path.points[1]);
    
      var normal = Vector.crossProduct(v1, v2).normalize();
    
      /**
       * Brightness is between -1 and 1 and is computed based
       * on the dot product between the light source vector and normal.
       */
      var brightness = Vector.dotProduct(normal, this.light.angle);
      var color = baseColor.lighten(brightness * this.color.difference, this.light.color);
      console.log(path.points.map(this.translatePoint.bind(this)));
      this.canvas.path(path.points.map(this.translatePoint.bind(this)), color);
    }

    translatePoint(point) {
      /**
       * X rides along the angle extended from the origin
       * Y rides perpendicular to this angle (in isometric view: PI - angle)
       * Z affects the y coordinate of the drawn point
       */
      var xMap = new Point(point.x * this.transformation[0][0],
        point.x * this.transformation[0][1]);

      var yMap = new Point(point.y * this.transformation[1][0],
          point.y * this.transformation[1][1]);

      var x = this.originX + xMap.x + yMap.x;
      var y = this.originY - xMap.y - yMap.y - (point.z * this.scale);
      return new Point(x, y);
    }

  }

  const scene = new Scene('game');
  const red = new Color(160, 60, 50);
  const blue = new Color(50, 60, 160);
  const green = new Color(0, 128, 0);
  
  scene.add(Shape.Prism(new Point(0, 0, 0)));

})(this);
