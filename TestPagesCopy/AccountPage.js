let reviewForm = document.querySelector(".review-form");
console.log(reviewForm);

let addReviewBtn = document.querySelector(".add-review");
console.log(addReviewBtn);
let closeReviewForm = document.querySelector(".close-review-form");

addReviewBtn.addEventListener("click", ()=>{
        reviewForm.style.display = "block";
    })

closeReviewForm.addEventListener("click", ()=>{
        reviewForm.style.display = "none";
    })