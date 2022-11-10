# How to bind the underlying DataTable model to the DataMarker Template in WPF Chart (SfChart)?

This example demonstrates how to bind the underlying item of the data table model to the data marker template in [WPF chart](https://help.syncfusion.com/wpf/charts/getting-started) by following these steps:

**Step 1:** First, you need to bind the data table to the chart [ItemsSource](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Charts.ChartSeriesBase.html#Syncfusion_UI_Xaml_Charts_ChartSeriesBase_ItemsSource) collection by following this [KB article](https://www.syncfusion.com/kb/5515/how-to-bind-data-table-in-the-sfchart).

**Step 2:** Then, you can display the underlying item of the data table model in data marker, by using the [LabelTemplate](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Chart.ChartAdornmentInfo.html#Syncfusion_Windows_Chart_ChartAdornmentInfo_LabelTemplate) in [ChartAdornmentInfo](https://help.syncfusion.com/cr/Syncfusion.Windows.Chart.ChartAdornmentInfo.html) class as demonstrated in the following code example.

**XAML**
```
<Grid>
    <Grid.Resources>
         <DataTemplate x:Key="adornment">
             <TextBlock  Text="{Binding Item.ItemArray[2]}" FontSize="13" FontWeight="Bold" RenderTransformOrigin="0.5,0.5" >
             </TextBlock>
         </DataTemplate>
    </Grid.Resources>
    <Grid.DataContext>
         <local:ViewModel />
    </Grid.DataContext>
    <chart:SfChart Margin="20">
         <chart:SfChart.PrimaryAxis>
             <chart:CategoryAxis Interval="1"></chart:CategoryAxis>
         </chart:SfChart.PrimaryAxis>
         <chart:SfChart.SecondaryAxis>
             <chart:NumericalAxis Maximum="9000"></chart:NumericalAxis>
         </chart:SfChart.SecondaryAxis>

         <chart:ColumnSeries x:Name="series"
                             Palette="Metro" 
                             ItemsSource="{Binding DataModel}"
                             XBindingPath="Month" YBindingPath="Value">
             <chart:ColumnSeries.AdornmentsInfo>
                 <chart:ChartAdornmentInfo LabelTemplate="{StaticResource adornment}" AdornmentsPosition="Top" VerticalAlignment="Top" 
                             HorizontalAlignment="Center" ShowLabel="True" SegmentLabelContent="LabelContentPath" />
             </chart:ColumnSeries.AdornmentsInfo>
         </chart:ColumnSeries>
    </chart:SfChart>
</Grid>
```

```
public class ViewModel
{

    public ViewModel()
    {
        DataModel = GetData();
    }
    public DataTable DataModel
    {
        get;
        set;
    }
    public DataTable GetData()
    {
        DataTable data = new DataTable();
        //Add Columns
        data.Columns.Add("Value", typeof(int));
        data.Columns.Add("Month", typeof(string));
        data.Columns.Add("Description", typeof(string));
        //Add Rows
        data.Rows.Add(250, "April", "Very Low");
        data.Rows.Add(750, "May", "Low");
        data.Rows.Add(7500, "June", "Very High");
        data.Rows.Add(3650, "July", "High");
        data.Rows.Add(2250, "August", "Intermediate");

        //return data
        return data;
    }
}
```

## Output:

![Binding adornment from data table WPF chart](https://user-images.githubusercontent.com/53489303/200744245-7955b18e-09e1-4e7b-a2f5-188ba98e3c77.png)

KB article - [How to bind the underlying DataTable model to the DataMarker Template in WPF Chart (SfChart)?](https://www.syncfusion.com/kb/11603/how-to-bind-the-underlying-datatable-model-to-the-datamarker-template-in-wpf-charts)
