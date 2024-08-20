# Client Project

This project is home to the source typescript, sass, and images used to generate the web root of the Web project.

<br />

## Overview

```
src/
    images/         # Source images
    models/         # Model classes
    pages/          # Page constructors
    repositories/   # Repository classes
    styles/         # Source styles
```

<br />

## Build

The build process will generate images, styles, and scripts in the `/wwwroot` of `Spokesoft.Clobberfest.Web`

```
gulp build:all
```

or build specific modules

```
gulp build:favicons
gulp build:fonts
gulp build:images
gulp build:scripts
gulp build:styles
```

<br />

### Clean the project

```
gulp clean:all
```

or clean specific modules

```
gulp clean:favicons
gulp clean:fonts
gulp clean:images
gulp clean:scripts
gulp clean:styles
```

<br />

### Watch for changes

```
gulp watch:all
```

or watch specific modules

```
gulp watch:favicons
gulp watch:fonts
gulp watch:images
gulp watch:scripts
gulp watch:styles
```