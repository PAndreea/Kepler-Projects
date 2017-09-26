
var obj = function () {

    this.Name = 'First test';

    this.a1 = function () {
        document.getElementById("demo").innerHTML = Date();
    }
    this.a2 = function () {
        document.getElementById('a').src = '/images/s.jpg';
    }
    this.a3 = function() {
        document.getElementById('a').src = '/images/lo.jpg';
    }
    this.a4 = function () {
        var inp = document.getElementById("idNumber");
        if (inp.checkValidity() == false)
            document.getElementById("idNumber2").innerHTML = inp.validationMessage;
        else document.getElementById("idNumber2").innerHTML = "Input ok";
    }
}

var firstObj = new obj();

function changeText(id) {
    id.innerHTML = "!!!OLLEH";
}

var obj2 = function () {
    this.a5 = function () {
        document.getElementById("demo1").innerHTML = "Hello Dolly.";

        var x, y, z;
        x = 5;
        y = 6;
        z = x + y;
        document.getElementById("demo2").innerHTML = "afiseaza z=x+y: " + z;

        var price1 = 5;
        var price2 = 12;
        var total = price1 + price2;
        document.getElementById("demo3").innerHTML = "The total is: " + total;

        var person = "John Doe", carName = "Volvo", price = 200;
        document.getElementById("demo4").innerHTML = "nume masina: " + carName;
        document.getElementById("demo5").innerHTML = "nume persoana:" + person;

        txt1 = "What a very ";
        txt1 += "nice day";
        document.getElementById("demo6").innerHTML = txt1;

        var cars = ["Saab", "Volvo", "BMW"];
        document.getElementById("demo7").innerHTML = "primul element din sir:" + cars[0];

        document.getElementById("demo8").innerHTML = "afiseaza tipul operatorilor John si 2: " + typeof "John" + " " + typeof "2" + " ";

        var person = {
            firstName: "John",
            lastName: "Doe",
            age: 50,
            eyeColor: "blue"
        };

        document.getElementById("demo8.1").innerHTML = person.firstName + " is " + person.age + " years old.";

        var y = "We are the so-called \"Vikings\" from the north.";
        document.getElementById("demo8.2").innerHTML = x + "<br>" + y;

        var txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        document.getElementById("demo8.3").innerHTML = "lungimea textului ABCDEFGHIJKLMNOPQRSTUVWXYZ este: " + txt.length;
    }

    this.a6 = function (p1, p2) {
        return p1 * p2;
    }

    this.toCelsius = function (f) {
        return (5 / 9) * (f - 32);
    }
}

var secondObj = new obj2();

var obj3 = function () {

    this.a7 = function () {
        var str = "Please locate where 'locate' occurs!";
        var pos = str.search("locate");
        document.getElementById("demo13").innerHTML = "Cauta locate in:Please locate where 'locate' occurs! si returneaza pozitia sa. " + pos;

        var str = "Apple, Banana, Kiwi";
        var res = str.slice(7, 13);
        var res2 = str.substring(3, 12);
        var res3 = str.substr(7, 9);
        document.getElementById("demo14").innerHTML = "Extrage o parte dintr-un string: " + res + " sau " + res2 + " sau " + res3;

        var text1 = "Hello(text 1)";
        var text2 = "World!(text 2)";
        var text3 = text1.concat(" ", text2);
        document.getElementById("demo14.1").innerHTML = "Concateneaza doua texte: " + text3;

        var str = "HELLO WORLD";
        document.getElementById("demo14.2").innerHTML = "Afiseaza doua o pozitie din sir: " + str.charAt(7);

        var x = 9.656;
        document.getElementById("demo14.3").innerHTML =
            x.toExponential() + " " +
            x.toExponential(2) + " " +
            x.toExponential(4) + " " +
            x.toExponential(6);

        var x = 9.656;
        document.getElementById("demo14.4").innerHTML =
            x.toFixed(0) + " " +
            x.toFixed(2) + " " +
            x.toFixed(4) + " " +
            x.toFixed(6);

        var x = 9.656;
        document.getElementById("demo14.5").innerHTML =
            x.toPrecision() + " " +
            x.toPrecision(2) + " " +
            x.toPrecision(4) + " " +
            x.toPrecision(6);

        document.getElementById("demo14.6").innerHTML = "Transforma true,false,new date(),' 10','10 ' si '10 6' in numere: " +
            Number(true) + " " +
            Number(false) + " " +
            Number(new Date()) + " " +
            Number("  10") + " " +
            Number("10  ") + " " +
            Number("10 6");

        document.getElementById("demo14.7").innerHTML = "Transforma string in numere: " +
            parseInt("10") + " " +
            parseInt("10.33") + " " +
            parseInt("10 6") + " " +
            parseInt("10 years") + " " +
            parseInt("years 10");

        document.getElementById("demo14.8").innerHTML = "Transforma string in numere(float): " +
            parseFloat("10") + " " +
            parseFloat("10.33") + " " +
            parseFloat("10 6") + " " +
            parseFloat("10 years") + " " +
            parseFloat("years 10");

        document.getElementById("demo14.9").innerHTML = "Cea mai mare valoare din JS: " + Number.MAX_VALUE;
    }

    this.a8 = function () {
        var str = document.getElementById("demo15").innerHTML;
        var txt = str.replace(/Microsoft/g, "W3Schools");
        document.getElementById("demo15").innerHTML = txt;
    }

    this.a9 = function () {
        var text = document.getElementById("demo16").innerHTML;
        document.getElementById("demo16").innerHTML = text.toUpperCase();
    }

    this.a10 = function () {
        document.getElementById("demo17").innerHTML = "Valoarea lui PI: " + Math.PI;

        document.getElementById("demo18").innerHTML = "Rotunjeste la cel mai apropiat interg pe 4.4 si 4.7 : " + Math.round(4.4) + " " + Math.round(4.7);

        document.getElementById("demo19").innerHTML = "Returneaza x la puterea y: " + Math.pow(8, 2);

        document.getElementById("demo20").innerHTML = "Returneaza radicalul unui numar: " + Math.sqrt(64);

        document.getElementById("demo21").innerHTML = "Returneaza modulul unui numar: " + Math.abs(-4.4);

        document.getElementById("demo22").innerHTML = "Rotunjeste in jos: " + Math.floor(4.7);

        document.getElementById("demo23").innerHTML =
            "The sine value of 90 degrees is " + Math.sin(90 * Math.PI / 180) + " And the cosine value of 0 degrees is " + Math.cos(0 * Math.PI / 180);

        document.getElementById("demo24").innerHTML = "Returneaza cea mai mica valoare: " + Math.min(0, 150, 30, 20, -8, -200);

        document.getElementById("demo25").innerHTML = "Returneaza cea mai mare valoare: " + Math.max(0, 150, 30, 20, -8, -200);

        document.getElementById("demo26").innerHTML = "Returneaza o valoar aleatoare intre 0 si 1: " + Math.random();

        document.getElementById("demo27").innerHTML = "Returneaza o valoare intre 0 si 100: " + Math.floor(Math.random() * 101);

        document.getElementById("demo28").innerHTML = "Returneaza o valoare intre 1 si 10: " + Math.floor((Math.random() * 10) + 1);

    }

    this.getRndInteger = function (min, max) {
        return Math.floor(Math.random() * (max - min)) + min;
    }

    this.a11 = function () {
        var d = new Date();
        document.getElementById("demo30").innerHTML = "The getTime() function returns the number of milliseconds since January 1, 1970: " + d.getTime();

        var d = new Date();
        document.getElementById("demo31").innerHTML = "Returneaza anul: " + d.getFullYear();

        var d = new Date();
        var days = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
        document.getElementById("demo32").innerHTML = "Returneaza ziua: " + days[d.getDay()];

        var msec = Date.parse("March 21, 2012");
        var d = new Date(msec);
        document.getElementById("demo33").innerHTML = "Use the number of milliseconds to convert it to a date object: " + d;

        var today, someday, text;
        today = new Date();
        someday = new Date();
        someday.setFullYear(2100, 0, 14);
        if (someday > today) {
            text = "Today is before January 14, 2100.";
        } else {
            text = "Today is after January 14, 2100.";
        }
        document.getElementById("demo34").innerHTML = text;

        var cars = ["Saab", "Volvo", "BMW"];
        document.getElementById("demo35").innerHTML = "Elementele unui sir: " + cars;

        var person = ["John", "Doe", 46];
        document.getElementById("demo36").innerHTML = "Primul element din sir: " + person[0];

        var fruits = ["Banana", "Orange", "Apple", "Mango"];
        document.getElementById("demo37").innerHTML = "Lungimea unui sir: " + fruits.length;

        fruits = ["Banana", "Orange", "Apple", "Mango"];
        fLen = fruits.length;
        text = "<ul>";
        for (i = 0; i < fLen; i++) {
            text += "<li>" + fruits[i] + "</li>";
        }
        text += "</ul>";
        document.getElementById("demo38").innerHTML = "Afiseaza elementele unui sir <br>" + text;
    }

    this.a12 = function () {
        var fruits = ["Banana", "Orange", "Apple", "Mango"];
        document.getElementById("demo39").innerHTML = fruits;
        fruits.push("Lemon");
        document.getElementById("demo39").innerHTML = "Adauga la sfarsitul sirului un nou element: " + fruits;

        var person = [];
        person[0] = "John";
        person[1] = "Doe";
        person[2] = 46;
        document.getElementById("demo40").innerHTML = "Afiseaza anumite elemente din sir: " +
            person[0] + " " + person.length;

        var fruits = ["Banana", "Orange", "Apple", "Mango"];
        document.getElementById("demo41").innerHTML = "Convert an array to string: " + fruits.join("*");

        var fruits = ["Banana", "Orange", "Apple", "Mango"];
        document.getElementById("demo42").innerHTML = "Sirul initial: " + fruits;
        fruits.pop();
        document.getElementById("demo43").innerHTML = "Sirul dupa aplicarea metodei pop(): " + fruits;
        fruits.push("Kiwi");
        document.getElementById("demo44").innerHTML = "Sirul dupa push(): " + fruits;
        fruits.shift();
        document.getElementById("demo45").innerHTML = "Sirul dupa shift(): " + fruits;

        fruits.unshift("Papaya");
        document.getElementById("demo46").innerHTML = "Sirul dupa unshift(): " + fruits;

        delete fruits[0];
        document.getElementById("demo47").innerHTML = "Sterge primul element din sir=>The first fruit is: " + fruits[0];
    }

    this.a13 = function () {
        var myGirls = ["Cecilie", "Lone"];
        var myBoys = ["Emil", "Tobias", "Linus"];
        var myChildren = myGirls.concat(myBoys);
        document.getElementById("demo48").innerHTML = "Concatenarea a doua siruri: " + myChildren;

        var fruits = ["Banana", "Orange", "Apple", "Mango"];
        fruits.sort();
        document.getElementById("demo49").innerHTML = "Sorteaza sirul: " + fruits;

        var points = [40, 100, 1, 5, 25, 10];
        points.sort(function (a, b) { return a - b });
        document.getElementById("demo50").innerHTML = "Sorteaza un sir de numere: " + points;
        points.sort(function (a, b) { return b - a });
        document.getElementById("demo51").innerHTML = "Sorteaza un sir de numere descrescator: " + points;
        document.getElementById("demo52").innerHTML = "Elementul maxim din sir: " + Math.max.apply(null, points);
        document.getElementById("demo53").innerHTML = "Elementul minim din sir: " + Math.min.apply(null, points);
    }

    this.a14 = function () {
        var age, voteable;
        age = document.getElementById("age").value;
        voteable = (age < 18) ? "Too young" : "Old enough";
        document.getElementById("demo54").innerHTML = voteable + " to vote.";
    }

    this.a15 = function () {
        var hour = new Date().getHours();
        var greeting;
        if (hour < 18) {
            greeting = "Good day";
        } else {
            greeting = "Good evening";
        }
        document.getElementById("demo55").innerHTML = greeting;

        var day;
        switch (new Date().getDay()) {
            case 0:
                day = "Sunday";
                break;
            case 1:
                day = "Monday";
                break;
            case 2:
                day = "Tuesday";
                break;
            case 3:
                day = "Wednesday";
                break;
            case 4:
                day = "Thursday";
                break;
            case 5:
                day = "Friday";
                break;
            case 6:
                day = "Saturday";
        }
        document.getElementById("demo56").innerHTML = "Today is " + day;

        var text;
        switch (new Date().getDay()) {
            case 6:
                text = "Today is Saturday";
                break;
            case 0:
                text = "Today is Sunday";
                break;
            default:
                text = "Looking forward to the Weekend";
        }
        document.getElementById("demo57").innerHTML = text;
    }
}

var thirdObj = new obj3();