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
    $("#datepicker, #datepicker2").datepicker();
});