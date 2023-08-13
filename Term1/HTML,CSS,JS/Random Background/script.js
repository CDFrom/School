document.getElementById('myBtn').onclick=changeBackground;

function changeBackground() {
  let r=Math.floor(Math.random()*256);
  let g=Math.floor(Math.random()*256);
  let b=Math.floor(Math.random()*256);
  let colorStr=`rgb(${r}, ${g}, ${b})`;

  document.body.style.background = colorStr;
  document.getElementById('p').innerHTML=colorStr;
}
