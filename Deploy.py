import shutil
import os


def move_compiled_gui_to_test_folder():
    compiled_gui_path = "C:\\Users\\Administrator\\source\\repos\\mmt-community\\3Dmigoto-Wheel-GUI\\bin\\Release\\"
    mmt_root_path = "C:\\Users\\Administrator\\Desktop\\DBMT\\"

    copy_file_name_list = ["DBMT-GUI.exe"]

    for filename in copy_file_name_list:
        shutil.copyfile(compiled_gui_path + filename, mmt_root_path + filename)
        print("Update: " + mmt_root_path + filename)


def move_compiled_plugin_to_test_folder():
    compiled_path = "C:\\Users\\Administrator\\source\\repos\\mmt-community\\x64\\Release\\"
    test_plugins_path = "C:\\Users\\Administrator\\Desktop\\DBMT\\Plugins\\"

    copy_file_name_list = ["DBMT.exe", "MMT-Naraka.exe"]

    for filename in copy_file_name_list:
        shutil.copyfile(compiled_path + filename, test_plugins_path + filename)
        print("Update: " + test_plugins_path + filename)


def deploy_to_release():
    print("Deploy to release:")
    compiled_gui_source_path = "C:\\Users\\Administrator\\source\\repos\\mmt-community\\3Dmigoto-Wheel-GUI\\bin\\Release\\"
    compiled_gui_target_path = "C:\\Users\\Administrator\\Desktop\\DBMT-Release\\"
    shutil.copyfile(compiled_gui_source_path + "DBMT-GUI.exe", compiled_gui_target_path + "DBMT-GUI.exe")
    print("Update: " + compiled_gui_target_path + "DBMT-GUI.exe")
    compiled_mmt_source_path = "C:\\Users\\Administrator\\source\\repos\\mmt-community\\x64\\Release\\"
    compiled_mmt_target_path = "C:\\Users\\Administrator\\Desktop\\DBMT-Release\\Plugins\\"
    shutil.copyfile(compiled_mmt_source_path + "DBMT.exe", compiled_mmt_target_path + "DBMT.exe")
    print("Update: " + compiled_mmt_target_path + "DBMT.exe")


# 此脚本用于编译完成后快速移动文件到DBMT的Plugins目录里进行测试，以及快速发布
if __name__ == '__main__':
    move_compiled_plugin_to_test_folder()
    print("-----------------------------------------")

    move_compiled_gui_to_test_folder()
    print("-----------------------------------------")

    deploy_to_release()
    print("-----------------------------------------")


