(() => {
    return {
        add: (a, b) => ([a[0] + b[0], a[1] + b[1]]),
        multiply: (a, scalar) => ([a[0] * scalar, a[1] * scalar]),
        length: (a) => Math.sqrt(a[0] * a[0] + a[1] * a[1]),
        dot: (a, b) => (a[0] * b[0] + a[1] * b[1]),
        cross: (a, b) => (a[0] * b[1] - a[1] * b[0])

    };
})()
