
#if INTERACTIVE
#I @"../../bin/Debug"
#I @"../../bin/Release"
#load "../../packages/Aardvark.Rendering.Interactive/scripts/LoadReferences.fsx"
#load @"../../packages/FSharp.Formatting/FSharp.Formatting.fsx"
#else
namespace Examples
#endif

open System
open Aardvark.Base
open Aardvark.Rendering.Interactive

open Default // makes viewTrafo and other tutorial specicific default creators visible

open Aardvark.Base.Incremental
open Aardvark.SceneGraph
open Aardvark.Application

open System.IO
open FSharp.Literate

module Stuff = 

    Aardvark.Rendering.Interactive.FsiSetup.init (Path.combine [__SOURCE_DIRECTORY__; ".."; ".."; "bin";"Debug"])

    
    let idx() =
        let r = [
            "project-name", "Blog"
            "page-title", "Blog"
            "page-author", "Attila Szabo"
            "github-link", "https://github.com/aszabo314"
        ]
        let index = Path.combine [__SOURCE_DIRECTORY__; "index.fs"]
        let template = Path.combine [__SOURCE_DIRECTORY__; "template-index.html"]
        Literate.ProcessScriptFile(index,template, replacements=r)

    let tg () =
        let r = [
            "project-name", "Terrain Generator"
            "page-title", "Terrain Generator Documentation"
            "page-author", "Attila Szabo"
            "github-link", "https://github.com/aszabo314/FSketch"
            "symbol-picture", "logo.png"
        ]
        let doc = Path.combine [__SOURCE_DIRECTORY__; "terraingenerator.fs"]
        let template = Path.combine [__SOURCE_DIRECTORY__; "template.html"]
        let output = Path.combine [__SOURCE_DIRECTORY__; "stuff"; "terraingenerator.html"]
        Literate.ProcessScriptFile(doc,template,output, replacements = r,generateAnchors=true)



open Stuff

