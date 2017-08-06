use gene_detection;
create table TB_Hospital
(
Hospital_ID int(4)  NOT NULL AUTO_INCREMENT PRIMARY KEY COMMENT '客户编号',
FULLName nvarchar(100) not null comment '全称',
Alias nvarchar(100) not null comment '曾用名（简称）',
Grade varchar(10) null comment '级别等级',
Hospital_Type varchar(10) null comment '医院性质 0国有，1私有，2合资',
WWW varchar(100) null comment '网址',
TELPHONE1 varchar(20) NULL COMMENT '电话1',
TELPHONE2 varchar(20) NULL COMMENT '电话2',
ShippingAddress varchar(500) NULL COMMENT '地址1',
BillingAddress varchar(500) NULL COMMENT '地址2',
DELETE_FLG varchar(2) NOT NULL default '0' COMMENT '删除标记 0否 1删除',
MAKE_TIME datetime NULL COMMENT '生成时间',
MAKE_OPERATER nvarchar(50) NULL COMMENT '生成操作员',
MODIFY_TIME datetime NULL COMMENT '修改时间',
MODIFY_OPERATER nvarchar(50) NULL COMMENT '修改操作员'
)