using System;
using System.Collections.Generic;
using Mono.WebAssembly.Browser.DOM.Events;

namespace Mono.WebAssembly.Browser.DOM
{
    public class DOMEventArgs : EventArgs
    {

        public int ClientX { get; internal set; }
        public int ClientY { get; internal set;  }
        public int OffsetX { get; internal set;  }
        public int OffsetY { get; internal set; }
        public int ScreenX { get; internal set; }
        public int ScreenY { get; internal set; }
        public bool AltKey { get; internal set; }
        public bool CtrlKey { get; internal set; }
        public bool ShiftKey { get; internal set; }
        public int KeyCode { get; internal set; }
        public int CharCode { get; internal set; }
        public string EventType { get; internal set; }
        public JSObject Source { get; internal set; }
        public Event EventObject { get; internal set; }


        internal DOMEventArgs(JSObject source, string type, string typeOfEvent, string eventHandle, string eventInfo)
        {
            this.Source = source;
            this.EventType = type;

            //Console.WriteLine($"EventHandle: {eventHandle}");

            if (typeOfEvent == "MouseEvent")
            {
                this.EventObject = new MouseEvent(Convert.ToInt32(eventHandle));
            }
            else if (typeOfEvent == "DragEvent")
            {
                this.EventObject = new DragEvent(Convert.ToInt32(eventHandle));
            }
            else if (typeOfEvent == "FocusEvent")
            {
                this.EventObject = new FocusEvent(Convert.ToInt32(eventHandle));
            }
            else if (typeOfEvent == "WheelEvent")
            {
                this.EventObject = new WheelEvent(Convert.ToInt32(eventHandle));
            }
            else if (typeOfEvent == "KeyboardEvent")
            {
                this.EventObject = new KeyboardEvent(Convert.ToInt32(eventHandle));
            }
            else if (typeOfEvent == "ClipboardEvent")
            {
                this.EventObject = new ClipboardEvent(Convert.ToInt32(eventHandle));
            }
            else 
            {
                this.EventObject = new Event(Convert.ToInt32(eventHandle));
            }


            if (eventInfo != null)
            {
                var ei = eventInfo.Substring(1, eventInfo.Length - 2).Split(',');
                var eventInfoDic = new Dictionary<string, string>();
                string value = null;
                foreach (var eip in ei)
                {
                    //Console.WriteLine(eip);
                    var kvp = eip.Split(':');
                    var key = kvp[0].Substring(1, kvp[0].Length - 2);
                    value = kvp[1];
                    if (value.StartsWith("\""))
                        eventInfoDic.Add(key, value.Substring(1, value.Length - 2));
                    else
                        eventInfoDic.Add(key, value);

                }
                //Console.WriteLine(eventInfo.Substring(1, eventInfo.Length - 2));

                //var eventInfoDic = Runtime.DeserializeJSON(eventInfo) as Dictionary<string, object>;

                //foreach(var key in eventInfoDic.Keys)
                //{
                //    Console.WriteLine($"Key: {key} - Value: {eventInfoDic[key]}");
                //}

                value = null;

                if (eventInfoDic.TryGetValue("clientX", out value))
                {
                    this.ClientX = Convert.ToInt32(value);
                }

                if (eventInfoDic.TryGetValue("clientY", out value))
                {
                    this.ClientY = Convert.ToInt32(value);
                }

                if (eventInfoDic.TryGetValue("offsetX", out value))
                {
                    this.OffsetX = Convert.ToInt32(value);
                }
                if (eventInfoDic.TryGetValue("offsetY", out value))
                {
                    this.OffsetY = Convert.ToInt32(value);
                }

                if (eventInfoDic.TryGetValue("screenX", out value))
                {
                    this.ScreenX = Convert.ToInt32(value);
                }
                if (eventInfoDic.TryGetValue("screenY", out value))
                {
                    this.ScreenY = Convert.ToInt32(value);
                }

                if (eventInfoDic.TryGetValue("altKey", out value))
                {
                    this.AltKey = Convert.ToBoolean(value);
                }

                if (eventInfoDic.TryGetValue("ctrlKey", out value))
                {
                    this.CtrlKey = Convert.ToBoolean(value);
                }
                if (eventInfoDic.TryGetValue("shiftKey", out value))
                {
                    this.ShiftKey = Convert.ToBoolean(value);
                }

                if (eventInfoDic.TryGetValue("keyCode", out value))
                {
                    this.KeyCode = Convert.ToInt32(value);
                }

                if (eventInfoDic.TryGetValue("charCode", out value))
                {
                    this.CharCode = Convert.ToInt32(value);
                }

                if (eventInfoDic != null)
                {
                    this.EventObject.InitEvent(eventInfoDic);
                }

            }

        }

        public void PreventDefault()
        {
            if (this.EventObject != null)
                this.EventObject.PreventDefault();
        }

        public void StopPropagation()
        {
            if (this.EventObject != null)
                this.EventObject.StopPropagation();
        }

    }
}
