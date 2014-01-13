﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicMongoDBTool.Common
{
    public abstract class PlugBase
    {
        /// <summary>
        /// 路径阶层[考虑到以后可能阶层会变换]
        /// </summary>
        public enum PathLv : int
        {
            /// <summary>
            /// 连接/服务器
            /// </summary>
            ConnectionLV = 0,
            /// <summary>
            /// 具体的实例
            /// </summary>
            InstanceLV = 1,
            /// <summary>
            /// 数据库
            /// </summary>
            DatabaseLV = 2,
            /// <summary>
            /// 数据集
            /// </summary>
            CollectionLV = 3,
            /// <summary>
            /// 数据文档
            /// </summary>
            DocumentLV = 4
        }
        public string PlugName = String.Empty;
        /// <summary>
        /// 处理对象
        /// </summary>
        public dynamic PlugObj;
        /// <summary>
        /// 对象层次
        /// </summary>
        public PathLv RunLv = PathLv.ConnectionLV;
        /// <summary>
        /// 运行
        /// </summary>
        /// <returns></returns>
        public abstract int Run(); 
    }
}
