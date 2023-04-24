# Refit-Demo

Ein kurzes Demo Projekt wie man Refit mit Authentication eisnetzen kann. Einmal mit Keycloak und named client und auch für die normale AuthApi oder ganz ohne Auth.

### Connectionstring.json erstellen

```
{
    "TaskUser" : {
    "Username" : "username",
    "Password" : "password"
    }
}
```

### Keycloak.json erstellen

```
{
  "realm": "staging",
  "auth-server-url": "https://login.xxx.com/auth/",
  "ssl-required": "external",
  "resource": "name",
  "verify-token-audience": true,
  "credentials": {
    "secret": "secret"
  },
  "confidential-port": 0,
  "policy-enforcer": {}
}
```



