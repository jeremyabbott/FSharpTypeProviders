module SeqOperations

let printSeq func seq =
    seq |> Seq.iter func