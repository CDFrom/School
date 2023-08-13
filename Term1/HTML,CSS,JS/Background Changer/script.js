let num=1;

function swap() {
  if(num==1){
    num=2;
  }
  else{
    num=1;
  }
  document.getElementById('img').src = "img/img ("+num+").jpg";
}
