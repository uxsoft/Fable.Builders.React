# Fable.Builders.React

<img src="https://buildstats.info/nuget/Fable.Builders.AntDesign" alt="badge"/>

These are F# / Fable bindings for the React framework

## Getting Started

```bash
dotnet package add Fable.Builders.React
```

```bash
yarn add react react-dom
```

## Usage 

```fsharp
[<ReactComponent>]
let MyComponent (props: {| MyProp: string |}) =
    div {
        style 
            [ style.float'.right ]
        
        button {
            str props.MyProp
        }
    }


```
