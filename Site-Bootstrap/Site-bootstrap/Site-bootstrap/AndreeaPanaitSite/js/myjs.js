
function adauga() {
            var inp1 = document.getElementById("num");
            var inp2 = document.getElementById("pre");
            var inp3 = document.getElementById("datepicker");
            var inp4 = document.getElementById("datepicker2");
            if (inp1.value == "" || inp2.value == "" || inp3.value == "" || inp4.value == "")
                alert("Completati toate datele pentru a putea face rezervarea!");
            else {
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
        }

function myMap() {
            var myCenter = new google.maps.LatLng(51.508742, -0.120850);
            var mapProp = {center: myCenter, zoom: 8, scrollwheel: true, draggable: true, mapTypeId: google.maps.MapTypeId.ROADMAP };
            var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);
            var marker = new google.maps.Marker({position: myCenter });
            marker.setMap(map);
        }

