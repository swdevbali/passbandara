@echo off
tools\xdelta32.exe -f -d -s AutoUpdate\PassBandaraUpdate.rar C:\AutoUpdate\PassBandaraUpdate.delta C:\AutoUpdate\PassBandaraUpdatePatch.rar
tools\unrar -y e C:\AutoUpdate\PassBandaraUpdatePatch.rar