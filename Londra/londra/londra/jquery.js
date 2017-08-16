$(document).ready(function () {
    $(".hidebt").click(function () {
        $(".hide").hide();
    });
});

$(document).ready(function () {
    $(".butonlist").click(function () {
        $("ul li:first-child").css("color", "red");
    });
});

$(document).ready(function () {
    $("tr:even").css("background-color", "yellow");
});

$(document).ready(function () {
    $(".buton").click(function () {
        $("a[target='_blank']").hide();
    });
});

$(document).ready(function () {
    $(".hidep").dblclick(function () {
        $(this).hide();
    });
});

$(document).ready(function () {
    $("input").focus(function () {
        $(this).css("background-color", "#cc99ff");
    });
    $("input").blur(function () {
        $(this).css("background-color", "#99ffbb");
    });
});

$(document).ready(function () {
    $(".mouse").on({
        mouseenter: function () {
            $(this).css("color", "red");
        },
        mouseleave: function () {
            $(this).css("color", "blue");
        },
        click: function () {
            $(this).css("color", "green");
        }
    });
});

$(document).ready(function () {
    $("#hide").click(function () {
        $(".hid").hide();
    });
    $("#show").click(function () {
        $(".hid").show();
    });
});

$(document).ready(function () {
    $(".buton2").click(function () {
        $(".toggle").toggle();
    });
});

$(document).ready(function () {
    $(".buton3").click(function () {
        $("#div1").fadeToggle(3000);
        $("#div2").fadeToggle(6000);
        $("#div3").fadeToggle(9000);
    });
});

$(document).ready(function () {
    $(".buton4").click(function () {
        $("#div11").fadeTo("slow", 0.15);
        $("#div22").fadeTo("slow", 0.4);
        $("#div33").fadeTo("slow", 0.7);
    });
});

$(document).ready(function () {
    $("#flip").click(function () {
        $("#panel").slideToggle("slow");
    });
});

$(document).ready(function () {
    $(".buton5").click(function () {
        $(".div4").animate({
            left: '250px',
            opacity: '0.5',
            height: '150px',
            width: '150px'
        });
    });
});

$(document).ready(function () {
    $(".buton6").click(function () {
        var div = $(".div5");
        div.animate({ height: '300px', opacity: '0.4' }, "slow");
        div.animate({ width: '300px', opacity: '0.8' }, "slow");
        div.animate({ height: '100px', opacity: '0.4' }, "slow");
        div.animate({ width: '100px', opacity: '0.8' }, "slow");
    });
});

$(document).ready(function () {
    $(".buton7").click(function () {
        $("#p1").css("color", "red").slideUp(2000).slideDown(2000);
    });
});

$(document).ready(function () {
    $("#btn1").click(function () {
        alert("Text: " + $("#test").text());
    });
    $("#btn2").click(function () {
        alert("HTML: " + $("#test").html());
    });
});

$(document).ready(function () {
    $(".buton8").click(function () {
        alert($("#w3s").attr("href"));
    });
});

$(document).ready(function () {
    $("#btn11").click(function () {
        $("#test11").text("Hello world!");
    });
    $("#btn22").click(function () {
        $("#test2").html("<b>Hello world!</b>");
    });
    $("#btn3").click(function () {
        $("#test3").val("Dolly Duck");
    });
});

$(document).ready(function () {
    $("#btn12").click(function () {
        $("#test12").text(function (i, origText) {
            return "Old text: " + origText + " New text: Hello world! (index: " + i + ")";
        });
    });
});

$(document).ready(function () {
    $(".buton9").click(function () {
        $("#w3ss").attr({
            "href": "https://www.w3schools.com/jquery",
            "title": "W3Schools jQuery Tutorial"
        });
    });
});

$(document).ready(function () {
    $("#btn13").click(function () {
        $(".app").append(" <b>Appended text</b>.");
    });

    $("#btn23").click(function () {
        $("ol").append("<li>Appended item</li>");
    });
});

$(document).ready(function () {
    $(".buton10").click(function () {
        $("#divv").empty();
    });
});

$(document).ready(function () {
        $(".buton11").click(function () {
            $("h1, h2, p").addClass("blue");
            $("div").addClass("important");
        });
});