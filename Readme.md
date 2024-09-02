<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128640200/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T596666)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Accordion Control - Bind to Data Using the ChildrenPath Property

This example demonstrates how to create a [WPF Accordion Control](https://docs.devexpress.com/WPF/DevExpress.Xpf.Accordion.AccordionControl) and bind it to data using the [ChildrenPath](https://docs.devexpress.com/WPF/DevExpress.Xpf.Accordion.AccordionControl.ChildrenPath) property.


## Implementation Details

1. Bind the accordion control to a data source. To do this, use the [AccordionControl.ItemsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Accordion.AccordionControl.ItemsSource) property.
2. Specify the [AccordionControl.ChildrenPath](https://docs.devexpress.com/WPF/DevExpress.Xpf.Accordion.AccordionControl.ChildrenPath) property to create item hierarchy.
3. Set the [AccordionControl.DisplayMemberPath](https://docs.devexpress.com/WPF/DevExpress.Xpf.Accordion.AccordionControl.DisplayMemberPath) property to a data field with strings to display them in item headers.


## Files to Review

* [MainWindow.xaml](./CS/ChildrenPath/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ChildrenPath/MainWindow.xaml))
* [ViewModel.cs](./CS/ChildrenPath/ViewModel.cs) (VB: [ViewModel.vb](./VB/ChildrenPath/ViewModel.vb))


## Documentation

* [Accordion Control - Bind to Data](https://docs.devexpress.com/WPF/118635/controls-and-libraries/navigation-controls/accordion-control/data-binding)


## Related Examples

* [WPF Accordion - Bind to Data (HierarchicalDataTemplate)](https://github.com/DevExpress-Examples/wpf-accordion-bind-to-data-hierarchicaldatatemplate)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-accordion-bind-to-data-using-childrenpath&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-accordion-bind-to-data-using-childrenpath&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
