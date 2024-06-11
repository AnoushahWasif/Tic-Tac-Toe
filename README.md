
# Tic Tac Toe API

Welcome to the Tic Tac Toe API project! This project provides a RESTful API for playing the classic game of Tic Tac Toe.

## Features

- **Game State Management:** Tracks the state of the Tic Tac Toe game, including the current board configuration, active player, and game status.
- **Move Validation:** Validates moves made by players to ensure they are legal and update the game state accordingly.
- **Win Detection:** Detects winning conditions for either player or a draw condition when the board is full.
- **CORS Support:** Implements Cross-Origin Resource Sharing (CORS) to allow requests from the Angular app running on `http://localhost:4200`.

## Technologies Used

- **ASP.NET Core:** Framework for building cross-platform APIs using C#.
- **C#:** Programming language used for server-side logic.
- **Visual Studio:** Integrated development environment (IDE) for building and debugging .NET applications.

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/AnoushahWasif/TicTacToe.git
   ```

2. Open the solution file (`TicTacToeAPI.sln`) in Visual Studio.

3. Build the solution to restore dependencies and compile the project.

4. Press F5 to start the application. The API will be hosted on `https://localhost:44300` by default.

## Endpoints

- **GET `/api/game`**: Retrieves the current game state.
- **POST `/api/game/move`**: Makes a move in the game. Expects JSON payload with the coordinates of the move (e.g., `{ "x": 0, "y": 0 }`).

## Usage

1. Make requests to the API endpoints using your preferred HTTP client (e.g., Postman, cURL, Angular HttpClient).
2. Start a new game by sending a POST request to `/api/game`.
3. Make moves in the game by sending POST requests to `/api/game/move` with the coordinates of the desired move.
4. Retrieve the current game state at any time by sending a GET request to `/api/game`.

## Contributing

Contributions are welcome! If you have any suggestions, improvements, or feature requests, please open an issue or submit a pull request.
