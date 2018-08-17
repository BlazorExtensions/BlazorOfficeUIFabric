using System;
using Mono.WebAssembly.Browser.DOM;
using Mono.WebAssembly.Browser.DOM.Events;

namespace DragNDrop
{
    public class Dragger
    {
        public Dragger()
        {

            var document = HTMLPage.Document;

            HTMLElement dragged = null;

            // events fired on the draggable target */
            document.OnDrag += (Mono.WebAssembly.JSObject sender, DOMEventArgs args) =>
            {
                //Console.WriteLine("dragged");
            };

            document.OnDragStart += (Mono.WebAssembly.JSObject sender, DOMEventArgs args) => {
                Console.WriteLine("Drag Start");
                dragged = ((DragEvent)args.EventObject).Target.As<HTMLElement>();
                dragged.SetStyleAttribute("opacity", ".5");
            };


            document.OnDragEnd += (Mono.WebAssembly.JSObject sender, DOMEventArgs args) => {
                ((DragEvent)args.EventObject).Target.As<HTMLElement>().SetStyleAttribute("opacity", null);
            };

            document.OnDragLeave += (Mono.WebAssembly.JSObject sender, DOMEventArgs args) => {
                ((DragEvent)args.EventObject).Target.As<HTMLElement>().RemoveStyleAttribute("opacity");
            };


            //Events fired on the drop targets
            document.OnDragOver += (Mono.WebAssembly.JSObject sender, DOMEventArgs args) => {
                args.PreventDefault();
                args.StopPropagation();
                var target = ((DragEvent)args.EventObject).Target.As<HTMLElement>();
                if (target.ClassName == "dropzone")
                {

                    // A DropEffect must be set
                    ((DragEvent)args.EventObject).DataTransfer.DropEffect = DropEffect.Link;
                }
                else
                    // A DropEffect must be set
                    ((DragEvent)args.EventObject).DataTransfer.DropEffect = DropEffect.None;

            };

            document.OnDragEnter += (Mono.WebAssembly.JSObject sender, DOMEventArgs args) => {
                var target = ((DragEvent)args.EventObject).Target.As<HTMLElement>();
                if (target.ClassName == "dropzone")
                {
                    target.SetStyleAttribute("background", "purple");
                }
            };

            document.OnDragLeave += (Mono.WebAssembly.JSObject sender, DOMEventArgs args) => {
                var target = ((DragEvent)args.EventObject).Target.As<HTMLElement>();
                if (target.ClassName == "dropzone")
                {
                    target.SetStyleAttribute("background", "");
                }

            };

            document.OnDrop += (Mono.WebAssembly.JSObject sender, DOMEventArgs args) => {

                args.PreventDefault();
                args.StopPropagation();

                var target = ((DragEvent)args.EventObject).Target.As<HTMLElement>();
                if (target.ClassName == "dropzone")
                {
                    target.SetStyleAttribute("background", "");
                    dragged.ParentNode.RemoveChild(dragged);
                    target.AppendChild(dragged);
                }

            };
        }
    }
}
