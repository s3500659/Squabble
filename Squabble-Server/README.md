# Squabble Server

The Squabble Server (API) is the backend interface that acts as the middle person between the 
Squabble Web App and the database.

## Useful links

| Description  | URL |
| ------------ | --- |
| Squabble-Server (this project)  | https://github.com/RMIT-COSC2650-SP3-2021-Team-3/Squabble-Server  |
| Squabble-Client                 | https://github.com/RMIT-COSC2650-SP3-2021-Team-3/Squabble-Client  |
| Azure Portal*                   | https://portal.azure.com |

\* Azure hosts the database, the production deployments and the file/blob storage.

## Development

### Requirements

- C#
- .NET 5

### Running the code

1. Install dependencies with `nuget install`
2. Start the development server with `dotnet run`

The API server is now running. If you also want to run the Squabble Web App follow the instructions
in the `Squabble-Client` README.

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
