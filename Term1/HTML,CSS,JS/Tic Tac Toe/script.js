let board=[0,0,0,0,0,0,0,0,0]; //initial board
let win=[[0,1,2],[3,4,5],[6,7,8],[0,3,6],[1,4,7],[2,5,8],[0,4,8],[2,4,6]]; //winning positions
let turn = 0;

function checkWin(val)
{
  for(let rwin of win)
  {
    if(board[rwin[0]]==val&&board[rwin[1]]==val&&board[rwin[2]]==val)
    return true;
  }
  return false;
}

let divCells = document.getElementsByClassName('Cell');
for(let cell of divCells)
{
  cell.onclick = putSymbol;
}


function putSymbol()
{
  if(turn%2==0&&board[Number(this.title)]==0)
  {
    board[Number(this.title)]=1;

    if(checkWin(1))
    {
      //alert("Winner X")
      setTimeout(function() {restartGame(1);},500)
    }
    //alert("X Clicked...");
    this.style.backgroundImage="url('X.jpg')";
    turn++;
  }
  else if(board[Number(this.title)]==0) {
    board[Number(this.title)]=2;

    if(checkWin(2))
    {
      //alert("Winner O")
      setTimeout(function() {restartGame(2);},500)
    }
    //alert("O Clicked...")
    this.style.backgroundImage="url('O.jpg')";
    turn++;
  }
  if(turn==9&&checkWin(1)==false&&checkWin(2)==false)
  {
    //alert("It is a draw...")
    setTimeout(function() {restartGame(0);},500)
  }
}

document.getElementById('restart').onclick=reloadGame;

function reloadGame() {
  location.reload();
}

function restartGame(winner)
{
  //alert(winner);
  document.getElementById('Board').style.display="none";
  document.getElementById('GameOver').style.display="block";
  if(winner==1)
  {
    document.getElementById('txtGameOver').innerHTML="Congratulations Player-01 (X) Wins!";
  }
  else if(winner==2)
  {
    document.getElementById('txtGameOver').innerHTML="Congratulations Player-02 (O) Wins!";
  }
  else if(winner==0)
  {
    document.getElementById('txtGameOver').innerHTML="It Was A Draw.";
  }
}
