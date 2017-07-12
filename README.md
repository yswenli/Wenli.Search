# Wenli.Search
Wenli.Search是一个基于luence的全文搜索封装库

使用配置如下：

<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <configSections>
    <section name="searchConfig" type="Wenli.Search.SearchConfig,Wenli.Search" />
  </configSections>
  <searchConfig FSDirectory="E:\Wenli.Search\Wenli.Search.Demo\bin\Debug\SearchIndex" PanGuXmlFilePath="PanGu.xml" />
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5"/>
  </startup>
</configuration>



测试图如下：

<img src="https://github.com/yswenli/Wenli.Search/blob/master/Wenli.Search.Demo/bin/Debug/2017-07-12_174406.png?raw=true" alt="wenli.search" />
