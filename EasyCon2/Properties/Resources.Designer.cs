﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyCon2.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EasyCon2.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] Amiibo {
            get {
                object obj = ResourceManager.GetObject("Amiibo", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 操作说明：
        ///
        ///第一步，先截图，截图放大区域，截图后按住左键平移截图，滚轮放大缩小图片
        ///
        ///第二步，点击开始圈选(红)，右键圈选（这里圈选的是搜索范围），然后点击确定搜索范围
        ///
        ///第三步，点击开始圈选(绿)，右键圈选（这里群选的是搜索目标），然后点击确定搜索目标
        ///
        ///第四步，点击搜索测试，查看是否能找到目标图片
        ///
        ///第五步，动态测试，游戏内操作，查看是否能够找到目标图片，并且最高匹配度达到多少，以此作为自动更新最低匹配度或者判断找到的条件
        ///
        ///第六步，保持标签，脚本内就可以使用@该标签了
        ///
        ///每次修改后，务必保存标签，否则脚本内无法生效
        ///切勿在脚本运行时，保存标签，容易崩溃
        ///
        ///切换分辨率会导致之前在不同分辨率下的标签位移，建议标签上加上使用分辨率容易区分
        ///
        ///【搜图语法】
        ///语法：@搜图标签
        ///（@开头，搜索对应名称图标签所代表的图像）
        ///示例：
        ///    # 搜索5号路蛋屋主人对应的图片
        ///    $2 = @5号路蛋屋主人
        ///    # 判断匹配度是否大于95
        ///    IF $2 &gt; 95
        ///        PRINT $2 &amp; 找到了
        ///    ENDIF
        ///
        ///名词解释：
        ///        /// [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string capturedoc {
            get {
                return ResourceManager.GetString("capturedoc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon CaptureVideo {
            get {
                object obj = ResourceManager.GetObject("CaptureVideo", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Icon favicon {
            get {
                object obj = ResourceManager.GetObject("favicon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Byte[] 类型的本地化资源。
        /// </summary>
        internal static byte[] lua {
            get {
                object obj = ResourceManager.GetObject("lua", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 &lt;?xml version=&quot;1.0&quot;?&gt;
        ///&lt;SyntaxDefinition name = &quot;ECP&quot; extensions = &quot;.nxec&quot;&gt;
        ///  &lt;RuleSets&gt;
        ///    &lt;RuleSet ignorecase = &quot;true&quot;&gt;
        ///      &lt;Span name = &quot;LineComment&quot; bold=&quot;false&quot; italic=&quot;false&quot; color=&quot;Green&quot; stopateol = &quot;true&quot;&gt;
        ///        &lt;Begin&gt;#&lt;/Begin&gt;
        ///      &lt;/Span&gt;
        ///      &lt;KeyWords name = &quot;Funcs&quot; bold=&quot;true&quot; italic=&quot;false&quot; color=&quot;LightBlue&quot;&gt;
        ///        &lt;Key word = &quot;RAND&quot; /&gt;
        ///        &lt;Key word = &quot;TIME&quot; /&gt;
        ///        &lt;Key word = &quot;PRINT&quot; /&gt;
        ///        &lt;Key word = &quot;ALERT&quot; /&gt;
        ///        &lt;Key word = &quot;WAIT&quot; /&gt;
        ///        &lt;Key w [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string NX {
            get {
                return ResourceManager.GetString("NX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 所有代码不区分大小写，支持前置后置空格，支持行内注释。
        ///
        ///【注释】
        ///语法：# 注释内容
        ///（多写注释是个好习惯，尤其是分享脚本给别人的时候）
        ///
        ///【输出】
        ///语法：PRINT 输出内容
        ///（联机模式专用，在控制台显示文字）
        ///
        ///【消息推送】
        ///语法：ALERT 输出内容
        ///（联机模式专用，发送推送消息，基于推送加服务）
        ///注意！需要先关注&lt;pushplus推送加&gt;小程序生成token
        ///取得token后请在设置-&gt;推送设置页面配置，否则无法使用
        ///
        ///【按键】
        ///语法：键位 [持续时间(ms)|DOWN|UP]
        ///（键位可以取A、B、X、Y、L、R、ZL、ZR、MINUS(-)、PLUS(+)、LCLICK(按左摇杆)、RCLICK(按右摇杆)、HOME(返回系统)、CAPTURE(截屏)、LEFT、RIGHT、UP、DOWN；持续时间省略则为默认50ms）
        ///示例：A（按下A键50毫秒）
        ///示例：HOME 1000（按下Home键1秒）
        ///示例：LEFT DOWN（按住左十字键，需要手动用LEFT UP松开）
        ///
        ///【摇杆】
        ///语法：LS|RS 方向|角度 [, 持续时间(ms)]
        ///语法：LS| [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string scriptdoc {
            get {
                return ResourceManager.GetString("scriptdoc", resourceCulture);
            }
        }
    }
}
