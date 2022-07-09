module SimplerMath

let inline div a b =
  (float a) / (float b)

type System.Int32 with
  member inline x .div y = div x y

type System.Int64 with
  member inline x .div y = div x y

type System.Double with
  member inline x .div y = div x y