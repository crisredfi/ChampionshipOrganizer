﻿

#pragma checksum "C:\Users\aleix\Documents\Visual Studio 2012\Projects\ChampionshipOrganizer\ChampionshipOrganizer\GroupedItemsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5126B28ECDBF94DA53B9D9AE87F57DB2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace ChampionshipOrganizer
{
    partial class GroupedItemsPage : ChampionshipOrganizer.Common.LayoutAwarePage, IComponentConnector
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 62 "..\..\GroupedItemsPage.xaml"
                ((Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.ItemView_ItemClick;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 104 "..\..\GroupedItemsPage.xaml"
                ((Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.ItemView_ItemClick;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 114 "..\..\GroupedItemsPage.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Header_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 77 "..\..\GroupedItemsPage.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Header_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 46 "..\..\GroupedItemsPage.xaml"
                ((Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


