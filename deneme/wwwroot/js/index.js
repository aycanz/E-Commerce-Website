const initSlider = () => {
    const imageList = document.querySelector(".slider-wrapper .image-list");
    const slideButtons = document.querySelectorAll(".slider-wrapper .slide-button");

    slideButtons.forEach(button => {
        button.addEventListener("click", () => {
            const direction = button.id === "prev-slide" ? -1 : 1;
            const scrollAmount = imageList.clientWidth * direction;
            imageList.scrollBy({ left: scrollAmount, behavior: "smooth" });
        });
    });

    const handleSlideButtons = () => {
        const maxScrollLeft = imageList.scrollWidth - imageList.clientWidth;
        const scrollLeft = imageList.scrollLeft;

        document.getElementById("prev-slide").disabled = scrollLeft === 0;
        document.getElementById("next-slide").disabled = scrollLeft >= maxScrollLeft;
    };

    imageList.addEventListener("scroll", handleSlideButtons);

    handleSlideButtons();
};

window.addEventListener("load", initSlider);

