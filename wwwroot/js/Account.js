<<<<<<< HEAD

// 
=======
>>>>>>> dab56d54c6a63a1b38bfa07c00b50913872e9d48
function openModal() {
    const modalOverlay = document.getElementById("modalOverlay");
    modalOverlay.style.display = "flex";
    setTimeout(() => {
        modalOverlay.classList.add("active"); // Add active class after a slight delay
    }, 10);
}

function closeModal() {
    const modalOverlay = document.getElementById("modalOverlay");
    modalOverlay.classList.remove("active");
    setTimeout(() => {
        modalOverlay.style.display = "none";
    }, 200);
}

$(document).ready(function () {
    $("#submitButton").click(function () {
        var formData = $("#myForm").serialize();

        $.ajax({
            type: "POST",
            url: "/AccountController/Create",
            data: formData,
            success: function (response) {

            },
            error: function (error) {

                console.error(error);
            }
        });
    });
});
