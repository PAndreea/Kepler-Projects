$(document).ready(function () {
    $(".buton").eq(0).click(function () {
        $("#a").attr("src", "images/s.jpg");
    })
})

$(document).ready(function () {
    $(".click").eq(1).click(function () {
        $("#demo").text(Date());
    })
})

$(document).ready(function() {
    $(".buton").eq(1).click(function () {
    $("#a").attr("src", "images/lo.jpg");
    })
})

$(document).ready(function () {
    $(".click").eq(0).click(function () {
        $("body").toggleClass("asdf");
    });
})

$(document).ready(function () {
    $(".hide").click(function () {
        $("#hide").toggle();
    })
})

$(document).ready(function () {
    $(".header").click(function () {
        $("#panel").slideToggle("slow");
    });
});

$(document).ready(function () {
    $("#animate").click(function () {
        var img = $("#animate");
        img.animate({ width: '350px' }, "slow");
    });
    $("#animate").dblclick(function () {
        var img = $("#animate");
        img.animate({ width: '120px' }, "slow");
    });
});

$(function () {
    $("#datepicker, #datepicker2").datepicker({
        changeMonth: true,
        changeYear: true
    });
});

$(function () {
    $("#sortable").sortable({
        revert: true
    });
    
    $("ul, li").disableSelection();
});

$(function () {
    $(document).tooltip();
});

$(function () {
    function hexFromRGB(r, g, b) {
        var hex = [
            r.toString(16),
            g.toString(16),
            b.toString(16)
        ];
        $.each(hex, function (nr, val) {
            if (val.length === 1) {
                hex[nr] = "0" + val;
            }
        });
        return hex.join("").toUpperCase();
    }
    function refreshSwatch() {
        var red = $("#red").slider("value"),
            green = $("#green").slider("value"),
            blue = $("#blue").slider("value"),
            hex = hexFromRGB(red, green, blue);
        $("#swatch").css("background-color", "#" + hex);
    }

    $("#red, #green, #blue").slider({
        orientation: "horizontal",
        range: "min",
        max: 255,
        value: 127,
        slide: refreshSwatch,
        change: refreshSwatch
    });
    $("#red").slider("value", 255);
    $("#green").slider("value", 140);
    $("#blue").slider("value", 60);
});