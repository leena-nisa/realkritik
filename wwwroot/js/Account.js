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
                console.log("SUCCESSFUL SUBMISSION")
            },
            error: function (error) {

                console.error(error);
            }
        });
    });
});
