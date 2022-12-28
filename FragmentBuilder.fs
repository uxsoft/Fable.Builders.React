module Fable.Builders.React.FragmentBuilder

open Fable.Builders.Common
open Feliz

type FragmentBuilder() =
    inherit ReactBuilder()

    member _.Run(s: DSLElement) =
        React.fragment s.Children