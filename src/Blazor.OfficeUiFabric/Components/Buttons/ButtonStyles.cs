using Blazor.Extensions.MergeStyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.OfficeUiFabric.Components.Buttons
{
    public class ButtonStyles : StyleSet<ButtonStyles>
    {
        private Style description;
        private Style descriptionChecked;
        private Style descriptionDisabled;
        private Style descriptionHovered;
        private Style descriptionPressed;
        private Style flexContainer;
        private Style icon;
        private Style iconChecked;
        private Style iconDisabled;
        private Style iconExpanded;
        private Style iconExpandedHovered;
        private Style iconHovered;
        private Style iconPressed;
        private Style label;
        private Style labelChecked;
        private Style labelDisabled;
        private Style menuIcon;
        private Style menuIconChecked;
        private Style menuIconDisabled;
        private Style menuIconExpanded;
        private Style menuIconExpandedHovered;
        private Style menuIconHovered;
        private Style menuIconPressed;
        private Style rootChecked;
        private Style rootCheckedDisabled;
        private Style rootCheckedHovered;
        private Style rootCheckedPressed;
        private Style rootDisabled;
        private Style rootExpanded;
        private Style rootExpandedHovered;
        private Style rootFocused;
        private Style rootHovered;
        private Style rootPressed;
        private Style screenReaderText;
        private Style secondaryText;
        private Style textContainer;
        private Style splitButtonMenuIconDisabled;
        private Style splitButtonMenuIcon;
        private Style splitButtonMenuButtonExpanded;
        private Style splitButtonMenuButtonDisabled;
        private Style splitButtonMenuButtonChecked;
        private Style splitButtonMenuButton;
        private Style splitButtonFlexContainer;
        private Style splitButtonDivider;
        private Style splitButtonContainerHovered;
        private Style splitButtonContainerFocused;
        private Style splitButtonContainerDisabled;
        private Style splitButtonContainerCheckedHovered;
        private Style splitButtonContainerChecked;
        private Style splitButtonContainer;

        /// <summary>
        /// Style for the description text if applicable (for compound buttons.)
        /// </summary>
        public Style Description { get => this.description; set => this.description = value; }

        /// <summary>
        /// Style override for the description text when the button is checked.
        /// </summary>
        public Style DescriptionChecked { get => this.descriptionChecked; set => this.descriptionChecked = value; }

        /// <summary>
        /// Style override for the description text when the button is disabled.
        /// </summary>
        public Style DescriptionDisabled { get => this.descriptionDisabled; set => this.descriptionDisabled = value; }

        /// <summary>
        /// Style override for the description text when the button is hovered.
        /// </summary>
        public Style DescriptionHovered { get => this.descriptionHovered; set => this.descriptionHovered = value; }

        /// <summary>
        /// Style for the description text when the button is pressed.
        /// </summary>
        public Style DescriptionPressed { get => this.descriptionPressed; set => this.descriptionPressed = value; }

        /// <summary>
        /// Style for the flexbox container within the root element.
        /// </summary>
        public Style FlexContainer { get => this.flexContainer; set => this.flexContainer = value; }

        /// <summary>
        /// Style for the icon on the near side of the label.
        /// </summary>
        public Style Icon { get => this.icon; set => this.icon = value; }

        /// <summary>
        /// Style override for the icon when the button is checked.
        /// </summary>
        public Style IconChecked { get => this.iconChecked; set => this.iconChecked = value; }

        /// <summary>
        /// Style override for the icon when the button is disabled.
        /// </summary>
        public Style IconDisabled { get => this.iconDisabled; set => this.iconDisabled = value; }

        /// <summary>
        /// Style for the icon on the near side of the label when expanded.
        /// </summary>
        public Style IconExpanded { get => this.iconExpanded; set => this.iconExpanded = value; }

        /// <summary>
        /// Style for the icon on the near side of the label when expanded and hovered.
        /// </summary>
        public Style IconExpandedHovered { get => this.iconExpandedHovered; set => this.iconExpandedHovered = value; }

        /// <summary>
        /// Style for the icon on the near side of the label on hover.
        /// </summary>
        public Style IconHovered { get => this.iconHovered; set => this.iconHovered = value; }

        /// <summary>
        /// Style for the icon on the near side of the label when pressed.
        /// </summary>
        public Style IconPressed { get => this.iconPressed; set => this.iconPressed = value; }

        /// <summary>
        /// Style for the text content of the button.
        /// </summary>
        public Style Label { get => this.label; set => this.label = value; }

        /// <summary>
        /// Style override for the text content when the button is checked.
        /// </summary>
        public Style LabelChecked { get => this.labelChecked; set => this.labelChecked = value; }

        /// <summary>
        /// Style override for the text content when the button is disabled.
        /// </summary>
        public Style LabelDisabled { get => this.labelDisabled; set => this.labelDisabled = value; }

        /// <summary>
        /// Style for the menu chevron.
        /// </summary>
        public Style MenuIcon { get => this.menuIcon; set => this.menuIcon = value; }

        /// <summary>
        /// Style override for the menu chevron when the button is checked.
        /// </summary>
        public Style MenuIconChecked { get => this.menuIconChecked; set => this.menuIconChecked = value; }

        /// <summary>
        /// Style override for the menu chevron when the button is disabled.
        /// </summary>
        public Style MenuIconDisabled { get => this.menuIconDisabled; set => this.menuIconDisabled = value; }

        /// <summary>
        /// Style for the menu chevron when expanded.
        /// </summary>
        public Style MenuIconExpanded { get => this.menuIconExpanded; set => this.menuIconExpanded = value; }

        /// <summary>
        /// Style for the menu chevron when expanded and hovered.
        /// </summary>
        public Style MenuIconExpandedHovered { get => this.menuIconExpandedHovered; set => this.menuIconExpandedHovered = value; }

        /// <summary>
        /// Style for the menu chevron on hover.
        /// </summary>
        public Style MenuIconHovered { get => this.menuIconHovered; set => this.menuIconHovered = value; }

        /// <summary>
        /// Style for the menu chevron when pressed.
        /// </summary>
        public Style MenuIconPressed { get => this.menuIconPressed; set => this.menuIconPressed = value; }

        /// <summary>
        /// Style override for the root element in a checked state, layered on top of the root style.
        /// </summary>
        public Style RootChecked { get => this.rootChecked; set => this.rootChecked = value; }

        /// <summary>
        /// Style override applied to the root on hover in a checked, disabled state
        /// </summary>
        public Style RootCheckedDisabled { get => this.rootCheckedDisabled; set => this.rootCheckedDisabled = value; }

        /// <summary>
        /// Style override applied to the root on hover in a checked, enabled state
        /// </summary>
        public Style RootCheckedHovered { get => this.rootCheckedHovered; set => this.rootCheckedHovered = value; }

        /// <summary>
        /// Style override applied to the root on pressed in a checked, enabled state
        /// </summary>
        public Style RootCheckedPressed { get => this.rootCheckedPressed; set => this.rootCheckedPressed = value; }

        /// <summary>
        /// Style override for the root element in a disabled state, layered on top of the root style.
        /// </summary>
        public Style RootDisabled { get => this.rootDisabled; set => this.rootDisabled = value; }

        /// <summary>
        /// Style override applied to the root on when menu is expanded in the default, enabled,
        /// non-toggled state.
        /// </summary>
        public Style RootExpanded { get => this.rootExpanded; set => this.rootExpanded = value; }

        /// <summary>
        /// Style override applied to the root on hover in a expanded state on hover
        /// </summary>
        public Style RootExpandedHovered { get => this.rootExpandedHovered; set => this.rootExpandedHovered = value; }

        /// <summary>
        /// Style override applied to the root on hover in the default, enabled, non-toggled state.
        /// </summary>
        public Style RootFocused { get => this.rootFocused; set => this.rootFocused = value; }

        /// <summary>
        /// Style override applied to the root on hover in the default, enabled, non-toggled state.
        /// </summary>
        public Style RootHovered { get => this.rootHovered; set => this.rootHovered = value; }

        /// <summary>
        /// Style override applied to the root on pressed in the default, enabled, non-toggled state.
        /// </summary>
        public Style RootPressed { get => this.rootPressed; set => this.rootPressed = value; }

        /// <summary>
        /// Style override for the screen reader text.
        /// </summary>
        public Style ScreenReaderText { get => this.screenReaderText; set => this.screenReaderText = value; }

        /// <summary>
        /// Style for the description text if applicable (for compound buttons.)
        /// </summary>
        public Style SecondaryText { get => this.secondaryText; set => this.secondaryText = value; }

        /// <summary>
        /// Style override for the container div around a SplitButton element
        /// </summary>
        public Style SplitButtonContainer { get => this.splitButtonContainer; set => this.splitButtonContainer = value; }

        /// <summary>
        /// Style for container div around a SplitButton element when the button is checked.
        /// </summary>
        public Style SplitButtonContainerChecked { get => this.splitButtonContainerChecked; set => this.splitButtonContainerChecked = value; }

        /// <summary>
        /// Style for container div around a SplitButton element when the button is checked and
        /// hovered.
        /// </summary>
        public Style SplitButtonContainerCheckedHovered { get => this.splitButtonContainerCheckedHovered; set => this.splitButtonContainerCheckedHovered = value; }

        /// <summary>
        /// Style override for the container div around a SplitButton element in a disabled state
        /// </summary>
        public Style SplitButtonContainerDisabled { get => this.splitButtonContainerDisabled; set => this.splitButtonContainerDisabled = value; }

        /// <summary>
        /// Style for container div around a SplitButton element when the button is focused.
        /// </summary>
        public Style SplitButtonContainerFocused { get => this.splitButtonContainerFocused; set => this.splitButtonContainerFocused = value; }

        /// <summary>
        /// Style for container div around a SplitButton element when the button is hovered.
        /// </summary>
        public Style SplitButtonContainerHovered { get => this.splitButtonContainerHovered; set => this.splitButtonContainerHovered = value; }

        /// <summary>
        /// Style override for the divider element that appears between the button and menu button
        /// for a split button.
        /// </summary>
        public Style SplitButtonDivider { get => this.splitButtonDivider; set => this.splitButtonDivider = value; }

        /// <summary>
        /// Style override for the SplitButton FlexContainer.
        /// </summary>
        public Style SplitButtonFlexContainer { get => this.splitButtonFlexContainer; set => this.splitButtonFlexContainer = value; }

        /// <summary>
        /// Style override for the SplitButton menu button
        /// </summary>
        public Style SplitButtonMenuButton { get => this.splitButtonMenuButton; set => this.splitButtonMenuButton = value; }

        /// <summary>
        /// Style override for the SplitButton menu button element in a checked state
        /// </summary>
        public Style SplitButtonMenuButtonChecked { get => this.splitButtonMenuButtonChecked; set => this.splitButtonMenuButtonChecked = value; }

        /// <summary>
        /// Style override for the SplitButton menu button element in a disabled state.
        /// </summary>
        public Style SplitButtonMenuButtonDisabled { get => this.splitButtonMenuButtonDisabled; set => this.splitButtonMenuButtonDisabled = value; }

        /// <summary>
        /// Style override for the SplitButton menu button element in an expanded state
        /// </summary>
        public Style SplitButtonMenuButtonExpanded { get => this.splitButtonMenuButtonExpanded; set => this.splitButtonMenuButtonExpanded = value; }

        /// <summary>
        /// Style override for the SplitButton menu icon element
        /// </summary>
        public Style SplitButtonMenuIcon { get => this.splitButtonMenuIcon; set => this.splitButtonMenuIcon = value; }

        /// <summary>
        /// Style override for the SplitButton menu icon element in a disabled state
        /// </summary>
        public Style SplitButtonMenuIconDisabled { get => this.splitButtonMenuIconDisabled; set => this.splitButtonMenuIconDisabled = value; }

        /// <summary>
        /// Style for the text container within the flexbox container element (and contains the text
        /// and description).
        /// </summary>
        public Style TextContainer { get => this.textContainer; set => this.textContainer = value; }
    }



}
