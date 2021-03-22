module Assignment

type Tree =
    | Node of Tree * Tree
    | Leaf of int

let rec prod (t:Tree) :int =
    match prod with // Tree is a type, you need object in the expression
    // h::t is exporession for the list, but you have a tree object which is Leaf or Node
    |Leaf a  -> 0 
    |Node (h,t) -> h * sum t

let rec map (f:int->int) (t:Tree) :Tree =
    match t with
    |Leaf int -> Leaf (f int)
    |Node( hd::tl) ->f hd :: map f tl


let rec foldStr (nf:string -> string -> string) (lf:int->string) (t:Tree) :string =
    ""
