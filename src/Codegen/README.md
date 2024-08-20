# Codegen Project

This project is home to the templates used to generate components for clobberfest.

<br />

## Overview

Check out https://www.hygen.io/ for more information on how to use hygen.

```
.hygen.js       # Hygen extensions 
templates/      # Hygen templates
```

<br />

## Documentation

<br />

### Generate new data model

```
hygen data model --name User --schema Auth
```

Running the above example will generate the following files:
- `~/src/client/src/models/user.interface.ts`
- `~/src/client/src/models/user.model.ts`
- `~/src/client/src/models/user.repository.ts`
- `~/src/data/configuration/auth/UserConfiguration.cs`
- `~/src/data/interfaces/auth/IUser.cs`
- `~/src/data/models/auth/User.cs`
- `~/src/database/tables/Users.sql`

<br />

### Generate new web area

```
hygen web area --name Accounts
```

Running the above example will generate the following files:
- `~/src/web/areas/accounts/controllers/AccountsController.cs`
- `~/src/web/areas/accounts/models/AccountsPage.cs`
- `~/src/web/areas/accounts/views/_Layout.cs`
- `~/src/web/areas/accounts/views/_ViewStart.cs`

<br />

### Generate new web page

```
hygen web page --name Login --area Accounts
```

Running the above example will generate the following files:
- `~/src/client/src/pages/accounts/login.ts`
- `~/src/client/src/pages/accounts/login.interface.ts`
- `~/src/client/src/pages/accounts/login.scss`
- `~/src/web/areas/accounts/controllers/LoginController.cs`
- `~/src/web/areas/accounts/models/ILoginPage.cs`
- `~/src/web/areas/accounts/models/LoginPage.cs`
- `~/src/web/areas/accounts/views/LoginPage.cshtml`

<br />

## License

See `license.md` for more information.