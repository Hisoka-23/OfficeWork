gsap.from("#img1",{
    delay:0.4,
    opacity:0,
    duration:1,
    y:60
})

gsap.from("#img2",{
    delay:0.4,
    opacity:0,
    duration:1,
    x:100
}, "-=0.8")

gsap.from("#img3",{
    delay:0.4,
    opacity:0,
    duration:1,
    y:-60
}, "-=0.8")

gsap.from("#main h1",{
    delay:0.4,
    opacity:0,
    duration:1
}, "-=0.8")

gsap.from("#page2 h5, #page2 h1, #page2 #about-us", {
    opacity:0,
    stagger:0.4,
    scrollTrigger:{
        trigger:"#page2 h5",
        scroller:"#body",
        start:"top 60%",
    }
})