# soroban-bot

## Getting Started

### 1. Configure appsettings.json

This repository does **not** include a config file. You must create one yourself based on the provided template:

```bash
cp appsettings.demo.json appsettings.json
```

Then edit `appsettings.json` and fill in your actual values:

| Field | Description |
|---|---|
| `GitHubApp.AppId` | Your GitHub App's numeric ID |
| `GitHubApp.InstallationId` | The installation ID for the target org/repo |
| `GitHubApp.PrivateKey` | The RSA private key generated for your GitHub App (PEM format, newlines as `\n`) |
| `Kestrel.Endpoints.Http.Url` | The address and port the server listens on (default: `http://0.0.0.0:3456`) |

### 2. Run

```bash
dotnet run
```

Or run the published binary directly:

```bash
./soroban-bot
```

## LICENSE

MIT License
