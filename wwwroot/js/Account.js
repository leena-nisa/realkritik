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
    $("#myForm").submit(function (e) {
        var formData = $(this).serialize();
        $.ajax({
            type: "POST",
            url: "/Review/Create",
            data: formData,
            success: function () {
                window.location.reload();
            },
            error: function (error) {

                console.error(error);
            }
        });
    });
});
