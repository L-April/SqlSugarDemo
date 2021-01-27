﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlSugarDemo.Models
{
    
    [SugarTable("Student")]//当和数据库名称不一致时候可以设置别名
    public class Student
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)] //通过特性设置主键和自增列 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [SugarColumn(ColumnName ="Sex")]//数据库列名取自定义
        public string Sex { get; set; }
    }
}
