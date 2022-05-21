function DurationSelection() {
    var selected_2 = document.getElementById("select2");

    if (selected_2.value == 1) {
        document.getElementById("DurationInput").removeAttribute("hidden");
    }
}

function LocationSelection() {
    var selected_1 = document.getElementById("select1");

    if (selected_1.value == 1) {
        document.getElementById("LocationInput").removeAttribute("hidden");

    }
}

  function DurationInput() {
        var selected_2 = document.getElementById("select2");
        var DurationOption = document.getElementById("DurationOption");

        selected_2.value = document.getElementById("DurationInput").value;
        DurationOption.value = document.getElementById("DurationInput").value;
  }

    function LocationInput() {
        var selected_1 = document.getElementById("select1");

        var LocationOption = document.getElementById("LocationOption");

        selected_1.value = document.getElementById("LocationInput").value;
        LocationOption.value = document.getElementById("LocationInput").value;

        // console.log(option.value)
        //console.log(selected.value)
    }


 function HideInputs() {

        var hide = document.getElementById("AddTodo");

        var selected_1 = document.getElementById("select1");
        var selected_2 = document.getElementById("select2");

        var LocationInput = document.getElementById("LocationInput");
        var LocationOption = document.getElementById("LocationOption");

        var DurationInput = document.getElementById("DurationInput");
        var DurationOption = document.getElementById("DurationOption");

        hide.addEventListener('mouseout', function () {
            LocationInput.setAttribute("hidden", true);
            LocationInput.value = null;

             DurationInput.setAttribute("hidden", true);
             DurationInput.value = null;

        });

        LocationOption.value = 1;
        DurationOption.value = 1;
    }

