Example of entrypoint

[<EntryPoint>]
let main argv = 
    let solution = new SimpleArraySum(Console.In, Console.Out)
    solution.Sum
    0