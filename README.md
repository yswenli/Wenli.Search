# Wenli.Search
Wenli.Search是一个基于luence的全文搜索封装库

使用配置如下：

&lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
&lt;configuration&gt;
  &lt;configSections&gt;
    &lt;section name=&quot;searchConfig&quot; type=&quot;Wenli.Search.SearchConfig,Wenli.Search&quot; /&gt;
  &lt;/configSections&gt;
  &lt;searchConfig FSDirectory=&quot;E:\Wenli.Search\Wenli.Search.Demo\bin\Debug\SearchIndex&quot; PanGuXmlFilePath=&quot;PanGu.xml&quot; /&gt;
  &lt;startup&gt;
    &lt;supportedRuntime version=&quot;v4.0&quot; sku=&quot;.NETFramework,Version=v4.5&quot;/&gt;
  &lt;/startup&gt;
&lt;/configuration&gt;



测试图如下：

<img src="https://github.com/yswenli/Wenli.Search/blob/master/Wenli.Search.Demo/bin/Debug/2017-07-12_174406.png?raw=true" alt="wenli.search" />
