# CoreAuthAPI

Secure ASP.NET Core Web API for user authentication and registration.

## Installation

1. Clone the repository.
2. Navigate to the project directory.
3. Run `dotnet restore` to restore dependencies.
4. Update the database using Entity Framework Core migrations: `dotnet ef database update`.
5. Run the application: `dotnet run`.

## Usage

- Register a new user: `POST /api/User/register`
- Login with existing credentials: `POST /api/User/login`

## Contributing

Contributions are welcome! Please read the [Contribution Guidelines](CONTRIBUTING.md) before submitting pull requests.

## License

This project is licensed under the [MIT License](LICENSE).
