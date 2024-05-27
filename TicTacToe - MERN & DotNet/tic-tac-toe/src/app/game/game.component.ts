import { Component } from '@angular/core';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})
export class GameComponent {
  squares: string[] = Array(9).fill(null);
  currentPlayer: string = 'X';
  winner: string | null = null;

  makeMove(index: number): void {
    if (!this.squares[index] && !this.winner) {
      this.squares[index] = this.currentPlayer;
      this.checkWinner();
      this.currentPlayer = this.currentPlayer === 'X' ? 'O' : 'X';
    }
  }

  checkWinner(): void {
    const winPatterns: number[][] = [
      [0, 1, 2], [3, 4, 5], [6, 7, 8], // Rows
      [0, 3, 6], [1, 4, 7], [2, 5, 8], // Columns
      [0, 4, 8], [2, 4, 6] // Diagonals
    ];

    for (const pattern of winPatterns) {
      const [a, b, c] = pattern;
      if (this.squares[a] && this.squares[a] === this.squares[b] && this.squares[a] === this.squares[c]) {
        this.winner = this.squares[a];
        break;
      }
    }
  }

  restartGame(): void {
    this.squares = Array(9).fill(null);
    this.currentPlayer = 'X';
    this.winner = null;
  }
}
