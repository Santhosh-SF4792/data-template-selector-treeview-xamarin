# data-template-selector-treeview-xamarin
This repository demonstrates how to apply a DataTemplateSelector in the Xamarin.Forms SfTreeView control. It provides a sample implementation that dynamically selects and applies different data templates to tree nodes based on their type or properties, enabling flexible and context-aware UI customization for hierarchical data.

## Sample

### XAML
```xaml
<ContentPage.Resources>
        <ResourceDictionary>
            <local:ItemTemplateSelector x:Key="ItemTemplateSelector" />
        </ResourceDictionary>
    </ContentPage.Resources>

    <ContentPage.Content>
        <Grid>
            <syncfusion:SfTreeView x:Name="TreeView" ItemHeight="40"
                                   AutoExpandMode="RootNodesExpanded"
                                   ChildPropertyName="SubFiles"
                                   ItemTemplateContextType="Node"
                                   ItemsSource="{Binding ImageNodeInfo}" Indentation="20" 
                                 ExpanderWidth="40" ItemTemplate="{StaticResource ItemTemplateSelector}">
            </syncfusion:SfTreeView>
        </Grid>
    </ContentPage.Content>
```

### ItemTemplateSelector
```csharp
public class ItemTemplateSelector : DataTemplateSelector
{
    public DataTemplate Template1 { get; set; }
    public DataTemplate Template2 { get; set; }
    public ItemTemplateSelector()
    {
        this.Template1 = new DataTemplate(typeof(Template1));
        this.Template2 = new DataTemplate(typeof(Template2));
    }
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var treeviewNode = item as TreeViewNode;
        if (treeviewNode == null)
            return null;
        if (treeviewNode.Level == 0)
            return Template1;
        else
            return Template2;
    }
}
```

## Requirements to run the demo
Visual Studio 2017 or Visual Studio for Mac.
Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.
