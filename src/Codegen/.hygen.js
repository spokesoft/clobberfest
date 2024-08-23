const { resolve } = require('path');
const { singularize
    , pluralize
    , underscore
    , camelize
    , dasherize
    , humanize } = require('inflection');

const solutionRoot = resolve('../../');
const clientRoot = resolve(solutionRoot, 'src/client');
const codegenRoot = resolve(solutionRoot, 'src/codegen');
const commonRoot = resolve(solutionRoot, 'src/common');
const consoleRoot = resolve(solutionRoot, 'src/console');
const dataRoot = resolve(solutionRoot, 'src/data');
const databaseRoot = resolve(solutionRoot, 'src/database');
const restRoot = resolve(solutionRoot, 'src/rest');
const servicesRoot = resolve(solutionRoot, 'src/services');
const webRoot = resolve(solutionRoot, 'src/web');

const toKebab = (name) => dasherize(underscore(name));
const toModel = (name) => singularize(camelize(underscore(name)));
const toSchema = (schema) => camelize(underscore(schema));
const toTable = (name) => pluralize(camelize(underscore(name)));
const toTitle = (name) => humanize(underscore(name));

const toDataModelCsConfiguration = (name, schema) => resolve(dataRoot, 'Configuration', toSchema(schema), `${toModel(name)}Configuration.cs`);
const toDataModelCsInterface = (name, schema) => resolve(dataRoot, 'Interfaces', toSchema(schema), `I${toModel(name)}.cs`);
const toDataModelCsModel = (name, schema) => resolve(dataRoot, 'Models', toSchema(schema), `${toModel(name)}.cs`);
const toDataModelCsRepository = (name, schema) => resolve(dataRoot, 'Repositories', toSchema(schema), `${toModel(name)}Repository.cs`);
const toDataModelSqlTable = (name, schema) => resolve(databaseRoot, 'Tables', toSchema(schema), `${toTable(name)}.sql`);
const toDataModelTsInterface = (name, schema) => resolve(clientRoot, 'src/models', toKebab(toSchema(schema)), `${toKebab(toModel(name))}.interface.ts`);
const toDataModelTsModel = (name, schema) => resolve(clientRoot, 'src/models', toKebab(toSchema(schema)), `${toKebab(toModel(name))}.ts`)
const toDataModelTsRepository = (name, schema) => resolve(clientRoot, 'src/repositories', toKebab(toSchema(schema)), `${toKebab(toModel(name))}-repository.ts`)

const toWebAreaController = (name) => resolve(webRoot, 'Areas', camelize(name), 'Controllers', `${camelize(name)}Controller.cs`);
const toWebAreaLayout = (name) => resolve(webRoot, 'Areas', camelize(name), 'Views', '_Layout.cshtml');
const toWebAreaModel = (name) => resolve(webRoot, 'Areas', camelize(name), 'Models', `${camelize(name)}Page.cs`);
const toWebAreaViewStart = (name) => resolve(webRoot, 'Areas', camelize(name), 'Views', '_ViewStart.cshtml');

const toWebPageController = (name, area) => resolve(webRoot, 'Areas', camelize(area), 'Controllers', `${camelize(name)}Controller.cs`);
const toWebPageModel = (name, area) => resolve(webRoot, 'Areas', camelize(area), 'Models', `${camelize(name)}ViewModel.cs`);
const toWebPageView = (name, area) => resolve(webRoot, 'Areas', camelize(area), 'Views', `${camelize(name)}.cshtml`);

module.exports = {
    templates: resolve(codegenRoot, 'templates'),
    helpers: {
        // Export transform helpers
        toKebab,
        toModel,
        toSchema,
        toTable,
        toTitle,

        // Export path helpers
        toDataModelCsConfiguration,
        toDataModelCsInterface,
        toDataModelCsModel,
        toDataModelCsRepository,
        toDataModelSqlTable,
        toDataModelTsInterface,
        toDataModelTsModel,
        toDataModelTsRepository,

        toWebAreaController,
        toWebAreaLayout,
        toWebAreaModel,
        toWebAreaViewStart,

        toWebPageController,
        toWebPageModel,
        toWebPageView,
    }
}