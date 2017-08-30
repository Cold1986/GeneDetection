use test;
drop table TB_Physician
create table TB_Physician
(
Physician_ID int(4)  NOT NULL AUTO_INCREMENT PRIMARY KEY COMMENT '医师编号',
Active_Status varchar(2) NOT NULL default '0' COMMENT '审核状态 0未审核，1已审核 ',
Wechat_ID varchar(50) NULL COMMENT '微信ID',
QR_Code varchar(500) NULL COMMENT '情景码',
FirstName nvarchar(10) NULL COMMENT '名',
LastName nvarchar(10) NULL  COMMENT '姓',
Gender varchar(2) NOT NULL default '0' COMMENT '性别 0男 1女',
#Title nvarchar(100) NULL COMMENT '职称',
#Position nvarchar(100) NULL COMMENT '职务',
#Department nvarchar(100) NULL COMMENT '科室',
BIRTHDAY date NULL COMMENT '出生年月',
NATIONAL_ID varchar(4) NULL COMMENT '国家ID',
PASSPORT_ID varchar(4) NULL COMMENT '护照ID',
CELL_PHONE1 varchar(20) NULL COMMENT '手机1',
CELL_PHONE2 varchar(20) NULL COMMENT '手机2',
EMAIL1 varchar(50) NULL COMMENT '电子邮件1',
EMAIL2 varchar(50) NULL COMMENT '电子邮件2',
TELPHONE1 varchar(20) NULL COMMENT '电话1',
TELPHONE2 varchar(20) NULL COMMENT '电话2',
ADDRESS1 varchar(500) NULL COMMENT '地址1',
ADDRESS2 varchar(500) NULL COMMENT '地址2',
ADDRESS3 varchar(500) NULL COMMENT '地址3',
DELETE_FLG varchar(2) NOT NULL default '0' COMMENT '删除标记 0否 1删除',
MAKE_TIME datetime NULL COMMENT '生成时间',
MAKE_OPERATER nvarchar(50) NULL COMMENT '生成操作员',
MODIFY_TIME datetime NULL COMMENT '修改时间',
MODIFY_OPERATER nvarchar(50) NULL COMMENT '修改操作员'
)