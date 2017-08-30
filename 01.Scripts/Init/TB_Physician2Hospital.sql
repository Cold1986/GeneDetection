use test;
create table TB_Physician2Hospital
(
ID int(4)  NOT NULL AUTO_INCREMENT PRIMARY KEY COMMENT '编号',
Physician_ID int(4)  NOT NULL COMMENT '医师编号',
Hospital_ID int(4)  NOT NULL  COMMENT '客户编号',
StartDate date null comment '开始时间',
EndDate date null comment '结束时间',
Title nvarchar(100) NULL COMMENT '职称',
Position nvarchar(100) NULL COMMENT '职务',
Department nvarchar(100) NULL COMMENT '科室',
DELETE_FLG varchar(2) NOT NULL default '0' COMMENT '删除标记 0否 1删除',
MAKE_TIME datetime NULL COMMENT '生成时间',
MAKE_OPERATER nvarchar(50) NULL COMMENT '生成操作员',
MODIFY_TIME datetime NULL COMMENT '修改时间',
MODIFY_OPERATER nvarchar(50) NULL COMMENT '修改操作员',

KEY Physician_ID (Physician_ID),
 CONSTRAINT Physician_ID FOREIGN KEY  (Physician_ID)  references TB_Physician(Physician_ID) ,
KEY Hospital_ID (Hospital_ID),
 CONSTRAINT Hospital_ID FOREIGN KEY  (Hospital_ID)  references TB_Hospital(Hospital_ID) 

)

