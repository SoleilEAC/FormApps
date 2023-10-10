//$("#bluebins").on('change keydown keyup', function () {
//    CalculateAmount();
//});

//$("#bluebins").oninput = function () {
//    Func_b
//};
//function Func_b() {
//    alert("The val for the input field gets changed.");
//}

//function Calculate() {
//    document.getElementById("bluebins").innerText ='$250.00';
//}

//$(document).ready(function () {
//    $(function () {

//        $("#<%=bluebins%>").change(function () {
//            alert("change");
//            // Your code for second text chnage 
//            document.getElementById("<%=bbamount%>").value = '$250'; //Your second input value 

//        });
//    });
//});

//$(document).ready(function () {
//    $(function () {

//        $("#bluebins").change(function () {
//            alert("change");
//            // Your code for second text chnage 
//            document.getElementById("#bbamount").value = '$250'; //Your second input value 

//        });
//    });
//});

function Calcf() {

    var num1 = document.getElementById("inPrA").innerHTML;
    var num2 = document.getElementById("inPrB").innerHTML;
    var total1 = document.getElementById("bluebins").value;
    var total2 = document.getElementById("greenbins").value;

    var complete = parseFloat(num1) * parseFloat(total1);

    if (isNaN(complete) || complete < 0){
        document.getElementById("bbamount").value = "$0.00";
    }
    else { document.getElementById("bbamount").value = "$"+complete.toFixed(2); }

    var complete = parseFloat(num2) * parseFloat(total2);
    if (isNaN(complete) || complete < 0) {
        document.getElementById("gbamount").value = "$0.00";
    }
    else { document.getElementById("gbamount").value = "$" + complete.toFixed(2); }
    
  
}


  function showMyDialog(msg, alertype) {
            alert("");
            $(function () {
                toastr[alertype](msg, alertype,
                    {
                        positionClass: "toast-top-center",
                        closeButton: true,
                        timeOut: 0,
                        extendedTimeOut: 0,

                    })
            });
           
        }