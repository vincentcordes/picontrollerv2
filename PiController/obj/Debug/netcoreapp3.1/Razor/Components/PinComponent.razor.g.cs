#pragma checksum "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a66554e0add2e2b6f4e4783683036328331a90357e9f30f0ac0bd0140b103db7"
// <auto-generated/>
#pragma warning disable 1591
namespace PiController.Components
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using PiController;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\_Imports.razor"
using PiController.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
using PiControllerLib.PinControl;

#line default
#line hidden
#nullable disable
    public partial class PinComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
.togglebutton {
  border: none;
  color: #282c34;
  padding: 10px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin: 4px 2px;
  cursor: pointer;
  min-width: 80px;
  border-radius: 20%;
  min-height: 42px;
}

.td-text{
  align-content: center;
  text-align: center;
  vertical-align: middle;
  
  font-size: 16px;
}
.select{
  align-content: center;
  text-align: center;
  vertical-align: middle;
}
</style>

");
#nullable restore
#line 35 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
 if(Pin == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<h5>Initializing</h5>\r\n");
#nullable restore
#line 38 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "tr");
            __builder.AddAttribute(5, "style", "border-color: #3a3a3a");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "td");
            __builder.AddAttribute(8, "style", "border-color: #3a3a3a; vertical-align: middle");
#nullable restore
#line 42 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
__builder.AddContent(9, Pin.PinNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "td");
            __builder.AddAttribute(12, "style", "border-color: #3a3a3a; vertical-align: middle");
#nullable restore
#line 43 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
__builder.AddContent(13, Pin.PinFunction);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        \r\n");
#nullable restore
#line 45 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
         if(Pin.PinType == ePinType.GPIO)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
             if(Pin.GPIONumber == 14 || Pin.GPIONumber == 15)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "                <td></td>\r\n                <td></td>\r\n");
#nullable restore
#line 51 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "style", "border-color: #3a3a3a");
            __builder.AddMarkupContent(19, "\r\n                 \r\n                    ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "disabled", 
#nullable restore
#line 61 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
                                       ModeChangeDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "class", "togglebutton");
            __builder.AddAttribute(23, "style", "background-color:" + " " + (
#nullable restore
#line 61 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
                                                                                                          ModeToggleColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
                                                                                                                                    Pin.TogglePinMode

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 61 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
__builder.AddContent(25, Pin.PinMode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "style", "border-color: #3a3a3a; vertical-align: middle");
#nullable restore
#line 63 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
__builder.AddContent(30, Pin.InputValue);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 64 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "            <td style=\"border-color: #3a3a3a\"></td>\r\n            <td style=\"border-color: #3a3a3a\"></td>\r\n");
#nullable restore
#line 70 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "        \r\n");
#nullable restore
#line 72 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
         if(Pin.PinType != ePinType.GPIO)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "            ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "style", "border-color: #3a3a3a");
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "disabled", true);
            __builder.AddAttribute(40, "class", "togglebutton");
            __builder.AddAttribute(41, "style", "background-color:" + " " + (
#nullable restore
#line 75 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
                                                                                ToggleButtonColor

#line default
#line hidden
#nullable disable
            ) + ";" + " cursor:" + " default");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            <td style=\"border-color: #3a3a3a\"></td>\r\n");
#nullable restore
#line 79 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
             if(Pin.GPIONumber == 14 || Pin.GPIONumber == 15)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "                <td></td>\r\n                <td></td>\r\n");
#nullable restore
#line 86 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "style", "border-color: #3a3a3a");
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "disabled", 
#nullable restore
#line 90 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
                                       ToggleStateDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(51, "class", "togglebutton");
            __builder.AddAttribute(52, "style", "background-color:" + " " + (
#nullable restore
#line 90 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
                                                                                                           ToggleButtonColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
                                                                                                                                       Pin.ChangeState

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Toggle");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenElement(57, "td");
            __builder.AddAttribute(58, "style", "border-color: #3a3a3a");
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "disabled", 
#nullable restore
#line 93 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
                                       RepeatingToggleDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(62, "class", "togglebutton");
            __builder.AddAttribute(63, "style", "background-color:" + " " + (
#nullable restore
#line 93 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
                                                                                                               RepeatingButtonColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
                                                                                                                                               Pin.RepeatingToggleState

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 93 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
__builder.AddContent(65, RepeatToggleMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 95 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
         if(Pin.PinType == ePinType.GPIO)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
             if(Pin.GPIONumber == 14 || Pin.GPIONumber == 15)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "                <td></td>\r\n                <td></td>\r\n                <td></td>\r\n");
#nullable restore
#line 104 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "                ");
            __builder.OpenElement(70, "td");
            __builder.AddAttribute(71, "style", "border-color: #3a3a3a; vertical-align: middle");
            __builder.OpenElement(72, "input");
            __builder.AddAttribute(73, "type", "number");
            __builder.AddAttribute(74, "style", "max-width: 100px");
            __builder.AddAttribute(75, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 107 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
                                                                                                                                      Pin.TimeHigh

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(76, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Pin.TimeHigh = __value, Pin.TimeHigh, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "td");
            __builder.AddAttribute(79, "style", "border-color: #3a3a3a; vertical-align: middle");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "number");
            __builder.AddAttribute(82, "style", "max-width: 100px");
            __builder.AddAttribute(83, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 108 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
                                                                                                                                      Pin.TimeLow

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(84, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Pin.TimeLow = __value, Pin.TimeLow, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                ");
            __builder.OpenElement(86, "td");
            __builder.AddAttribute(87, "style", "border-color: #3a3a3a; vertical-align: middle");
            __builder.AddMarkupContent(88, "\r\n                    ");
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "class", "togglebutton");
            __builder.AddAttribute(91, "style", "background-color:" + " " + (
#nullable restore
#line 110 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
                                                                           LockColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(92, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
                                                                                                SetLock

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 110 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
__builder.AddContent(93, LockMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 112 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(96, "            <td style=\"border-color: #3a3a3a\"></td>\r\n            <td style=\"border-color: #3a3a3a\"></td>\r\n            <td style=\"border-color: #3a3a3a\"></td>\r\n");
#nullable restore
#line 119 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(97, "        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
#nullable restore
#line 122 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\Users\ynniv\Documents\repos\picontrollerv2\PiController\Components\PinComponent.razor"
       
    [Parameter]
    public int ID {get; set;} 
    public PiControllerLib.PinControl.Pin Pin;

    private string _ToggleButtonColor;
    public string ToggleButtonColor 
    {
        get {return _ToggleButtonColor;}
        set{_ToggleButtonColor = value;  NotifyDataChanged();}
    }
    
    public string RepeatingButtonColor => SetRepeatingColor();
    public string RepeatToggleMessage => SetRepeatingMessage();
    public string ModeToggleColor => SetModeToggleColor();
    public string LockColor => SetLockColor();
    public string LockMessage => SetLockMessage();
    public string ModeButtonColor => SetModeToggleColor();
    public bool PinLock = false;
    public bool ToggleStateDisabled => SetStateToggleDisabled();
    public bool ModeChangeDisabled => SetModeChangeDisabled();
    public bool RepeatingToggleDisabled => SetRepeatingToggleDisabled();
    
    
        
    public void SetPinColor()
    {
        //Dispatcher.InvokeAsync(() => {
            //Console.WriteLine($"Set color {Pin.PinNumber} {Pin.PinState.ToString()}");
            if(Pin.PinType == ePinType.Ground)
                ToggleButtonColor = "#42A2EF";
            if(Pin.PinType == ePinType.Power)
                if(Pin.PinFunction == "Power 5v")
                    ToggleButtonColor = "#992727";
                else
                    ToggleButtonColor = "#E06C75";
            if(Pin.PinType == ePinType.GPIO)
                if(Pin.PinState == eState.High)
                    ToggleButtonColor = "#E06C75";
                else
                    ToggleButtonColor = "#42A2EF";
        //});
    }
    public event Action OnChange;
    private void NotifyDataChanged() => InvokeAsync(() => { OnChange?.Invoke();});//?.Invoke();
    public string SetRepeatingMessage()
    {
        var message = "Start";
        if(Pin.RepeatingToggle)
            message = "Stop";
        
        return message;
    }
    public string SetRepeatingColor()
    {
        var color = "#98C379";
        if(Pin.RepeatingToggle)
            color = "#D19A66";
        return color; 
    }

    public bool SetStateToggleDisabled()
    {
        var disabled = false;
        if(PinLock || Pin.PinMode.ToString() == "Input" || Pin.RepeatingToggle)
            disabled = true;
        
        return disabled;
    }
    public bool SetRepeatingToggleDisabled()
    {
        var disabled = false;
        if(Pin.PinMode.ToString() == "Input" || PinLock)
            disabled = true;
        return disabled;
    }
    public void SetLock()
    {
        
        if(PinLock)
            PinLock = false;
        else
            PinLock = true;
    }

    public string SetLockColor()
    {
        var color = "#a14630";
        if(PinLock)
            color = "#278f82";
        return color;
    }

    public string SetLockMessage()
    {
        var message = "Lock";
        if(PinLock)
            message = "UnLock";
        return message;
    }

    public string SetModeToggleColor()
    {
        
        var color = "#cAa93C";
        if(Pin.PinMode.ToString() == "Input")
            color = "#8989ff";
        return color;
    }

    public bool SetModeChangeDisabled()
    {
        bool disabled = false;
        if(PinLock || Pin.RepeatingToggle)
            disabled = true;
        return disabled;
    }


    protected override async Task OnInitializedAsync()
    {
        Pin = await PinManager.GetPin(ID);
        Pin.Notify += SetPinColor;
        OnChange += StateHasChanged;
        SetPinColor();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.PinControl.PinControlService PinManager { get; set; }
    }
}
#pragma warning restore 1591
