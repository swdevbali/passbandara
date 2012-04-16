@echo off
@echo Creating directories and copying files..
mkdir PassBandaraUpdate
mkdir PassBandaraUpdate\Reports
copy AntrianForDisplay_1600x1200\bin\Debug\AntrianForDisplay_1600x1200.exe PassBandaraUpdate\
copy AntrianForDisplay_1980x1080\bin\Debug\AntrianForDisplay_1980x1080.exe PassBandaraUpdate\
copy AntrianForUser\bin\Debug\AntrianForUser.exe PassBandaraUpdate\
copy FlowPersetujuan\bin\Debug\FlowPersetujuan.exe PassBandaraUpdate\
copy MasterApplicationModule\bin\Debug\MasterModule.dll PassBandaraUpdate\
copy MasterTransaksi\bin\Debug\TransaksiModule.dll PassBandaraUpdate\
copy MasterTransaksi\bin\Debug\Reports\* PassBandaraUpdate\Reports\
copy MigrasiData\bin\Debug\MigrasiData.exe PassBandaraUpdate\
copy PassBandara\PassBandara\bin\Debug\PassBandara.exe PassBandaraUpdate\
copy PassBandara\PassBandara\bin\Debug\Reports\Antrian.lbx PassBandaraUpdate\Reports
copy RootSection\bin\Debug\RootSection.dll PassBandaraUpdate\
copy AirportPassConfiguration\bin\Debug\AirportPassConfiguration.exe PassBandaraUpdate\
@echo Archiving the result...
cd PassBandaraUpdate
..\rar -r -m5 a ..\PassBandaraUpdateLast.rar *.*
@echo Creating delta file...
cd ..
xdelta32 -f -e -s PassBandara\PassBandara\AutoUpdate\PassBandaraUpdate.rar PassBandaraUpdateLast.rar PassBandaraUpdate.delta
@echo Delete temporary files..
del PassBandaraUpdateLast.rar /Q
rd PassBandaraUpdate /S /Q