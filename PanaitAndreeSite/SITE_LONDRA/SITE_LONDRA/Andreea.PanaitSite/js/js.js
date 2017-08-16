/*function a1() {
    document.getElementById('a').src = '/images/s.jpg';
}

function data() {
    document.getElementById("demo").innerHTML = Date();
}

function a2() {
    document.getElementById('a').src = '/images/lo.jpg';
}

function toggleclass() {
    if (document.body.style.backgroundImage == 'url("images/rr.jpg")')
       document.body.style.backgroundImage = 'url("images/giphy.gif")';
    else
        document.body.style.backgroundImage = 'url("images/rr.jpg")';
}

function hideText() {
   if (document.getElementById('hide').style.visibility == 'hidden')
       document.getElementById('hide').style.visibility = 'visible';
   else
       document.getElementById('hide').style.visibility = 'hidden';
}*/

function adauga() {
    var tabel = document.getElementById("tab");
    var linie = tabel.insertRow(1);

    var data1 = linie.insertCell(0);
    var data2 = linie.insertCell(1);
    var data3 = linie.insertCell(2);
    var data4 = linie.insertCell(3);

    data1.innerHTML = document.forms["formular"]["nume"].value;
    data2.innerHTML = document.forms["formular"]["prenume"].value;
    data3.innerHTML = document.forms["formular"]["plecare"].value;
    data4.innerHTML = document.forms["formular"]["intoarcere"].value;
}
