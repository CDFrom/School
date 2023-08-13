//Initialize the board
let board = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
//Set winning conditions
let win = [
  [0, 1, 2],
  [3, 4, 5],
  [6, 7, 8],
  [9, 10, 11],
  [12, 13, 14],
  [15, 16, 17],
  [0, 3, 6],
  [3, 6, 9],
  [6, 9, 12],
  [9, 12, 15],
  [1, 4, 7],
  [4, 7, 10],
  [7, 10, 13],
  [10, 13, 16],
  [2, 5, 8],
  [5, 8, 11],
  [8, 11, 14],
  [11, 14, 17],
  [0, 4, 8],
  [3, 7, 11],
  [6, 10, 14],
  [9, 13, 17],
  [2, 4, 6],
  [5, 7, 9],
  [8, 10, 12],
  [11, 13, 15]
];
//Create a turn counter
let turn = 0;

//Create a function for checking win conditions
function checkWin(val) {
  for (let index of win) {
    if (board[index[0]] == val && board[index[1]] == val && board[index[2]] == val)
      return true;
  }
  return false;
}

//Check for cell click and call placement function
let divCells = document.getElementsByClassName('cell');
for (let cell of divCells) {
  cell.onclick = putDisc;
}

//Placement function for player discs
function putDisc() {
  //First player
  if (turn % 2 == 0) {
    let num = Number(this.title) % 3 + 15; //Set place to bottom of grid
    //Check for space availability bottom to top
    for (num; num >= 0; num -= 3) {
      if (board[num] == 0) {
        board[num] = 1;
        turn++;
        break;
      }
    }
    //Disc animation
    for (let i = num % 3; i <= num; i += 3) {
      setTimeout(function() {
        if (i < 3) {
          let current = i.toString();
          document.getElementById(current).style.background = "red";
        } else {
          let last = i - 3;
          last = last.toString();
          let current = i.toString();
          document.getElementById(last).style.background = "white";
          document.getElementById(current).style.background = "red";
        }
      }, i * 100)
    }
    //Check if player has won
    if (checkWin(1)) {
      setTimeout(function() {
        restartGame("Red");
      }, (num + 1) * 100);
    }
  }
  //Second player
  else {
    let num = Number(this.title) % 3 + 15; //Set place to bottom of grid
    //Check for space availability bottom to top
    for (num; num >= 0; num -= 3) {
      if (board[num] == 0) {
        board[num] = 2;
        turn++;
        break;
      }
    }
    //Disc animation
    for (let i = num % 3; i <= num; i += 3) {
      setTimeout(function() {
        if (i < 3) {
          let current = i.toString();
          document.getElementById(current).style.background = "yellow";
        } else {
          let last = i - 3;
          last = last.toString();
          let current = i.toString();
          document.getElementById(last).style.background = "white";
          document.getElementById(current).style.background = "yellow";
        }
      }, i * 100);
    }
    //Check if player has won
    if (checkWin(2)) {
      setTimeout(function() {
        restartGame("Yellow");
      }, (num + 1) * 100);
    }
  }
  //Check for draw
  if (turn == 18 && checkWin("Red") == false && checkWin("Yellow") == false) {
    setTimeout(function() {
      restartGame("Draw");
    }, 500);
  }
}

//Button function for playing again
document.getElementById('restart').onclick = reloadGame;

//Reload webpage
function reloadGame() {
  location.reload();
}

//Switch to win screen w/ display based upon winner
function restartGame(winner) {
  alert(winner);
  document.getElementById('board').style.display = "none";
  document.getElementById('gameOver').style.display = "block";
  if (winner == "Red") {
    document.getElementById('gameOverText').innerHTML = "Congratulations Red Wins!";
  } else if (winner == "Yellow") {
    document.getElementById('gameOverText').innerHTML = "Congratulations Yellow Wins!";
  } else if (winner == "Draw") {
    document.getElementById('gameOverText').innerHTML = "It Was A Draw.";
  }
}
