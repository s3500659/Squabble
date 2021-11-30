# Squabble Web App

The Squabble Web App (Client) is the frontend user interface for the Squabble Chat Application.

## Useful links

| Description  | URL |
| ------------ | --- |
| Squabble-Client (this project)  | https://github.com/RMIT-COSC2650-SP3-2021-Team-3/Squabble-Client  |
| Squabble-Server                 | https://github.com/RMIT-COSC2650-SP3-2021-Team-3/Squabble-Server  |
| Azure Portal*                   | https://portal.azure.com |

\* Azure hosts the database, the production deployments and the file/blob storage.

## Development

### Requirements

- Node.js v14

### Running the code

1. Install dependencies with `npm install`
2. Start the development server with `npm run start`
3. Start `Squabble-Server` (the API that communicates with the database)*
4. The project is now accessible locally at `http://localhost:4200` or `http://127.0.0.1:4200`

\* See the `Squabble-Server` source code for specific instructions on how to run this.

## Demo users

| Username   | Password |
| ---------- | -------- |
| Dragonborn | abc123   |
| Hayzeus    | dial911  |
| Spongebob  | abc123   |
| Squidward  | abc123   |
| Handyman   | abc123   |

## Deploying the code

See [DATA.txt](DATA.txt).

## Changelog

See [CHANGELOG.md](CHANGELOG.md).

To generate the changelog run `git log --format='- %s (Commit: %h) [Author: %aN]' > CHANGELOG.md`.

## Known issues/bugs

See [RELEASE.txt](RELEASE.txt).

## License

The source code is licensed under Creative Commons Attribution-NonCommercial-NoDerivatives 4.0
International.

This license allows reusers to copy and distribute the material in any medium or format in
unadapted form only, for noncommercial purposes only, and only so long as attribution is given to
the creator.

See [LICENSE.md](LICENSE.md) for the full text.
