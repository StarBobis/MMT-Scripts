import shutil
import os


def move_mmt_protect_gui():
    compiled_gui_path = "C:\\Users\\Administrator\\source\\repos\\mmt-community\\MMT-Protect-GUI\\bin\\Release\\"
    mmt_protect_path = "C:\\Users\\Administrator\\Desktop\\MMT-Protect-V1.0.0.7\\"

    copy_file_name_list = ["MMT-Protect-GUI.exe"]

    for filename in copy_file_name_list:
        shutil.copyfile(compiled_gui_path + filename, mmt_protect_path + filename)
        print("Update MMT-Protect-GUI.exe: " + mmt_protect_path + filename)


def move_all_injector_release_to_everygame_folder(mmt_version):
    injector_path = "C:\\Users\\Administrator\\Desktop\\MMT-Community-V"+mmt_version+"\\3Dmigoto-GameMod-Fork\\3Dmigoto Loader.py"
    games_path = "C:\\Users\\Administrator\\Desktop\\MMT-Community-V"+mmt_version+"\\Games\\"
    for dirname in os.listdir(games_path):
        target_game_d3d11dll_path = games_path + dirname + "\\3Dmigoto\\3Dmigoto Loader.py"
        shutil.copyfile(injector_path, target_game_d3d11dll_path)
        print("Update: " + target_game_d3d11dll_path)


def move_armor_dll_release_to_everygame_folder(mmt_version):
    armor_dll_path = "C:\\Users\\Administrator\\Desktop\\MMT-Community-V"+mmt_version+"\\3Dmigoto-GameMod-Fork\\ReleaseX64Dev\\d3d11.dll"
    games_path = "C:\\Users\\Administrator\\Desktop\\MMT-Community-V"+mmt_version+"\\Games\\"
    for dirname in os.listdir(games_path):
        target_game_d3d11dll_path = games_path + dirname + "\\3Dmigoto\\d3d11.dll"
        shutil.copyfile(armor_dll_path, target_game_d3d11dll_path)
        print("Update: " + target_game_d3d11dll_path)


def move_compiled_gui_to_test_folder():
    compiled_gui_path = "C:\\Users\\Administrator\\source\\repos\\mmt-community\\3Dmigoto-Wheel-GUI\\bin\\Release\\"
    mmt_root_path = "C:\\Users\\Administrator\\Desktop\\MMT-Community\\"

    copy_file_name_list = ["MMT-GUI.exe"]

    for filename in copy_file_name_list:
        shutil.copyfile(compiled_gui_path + filename, mmt_root_path + filename)
        print("Update: " + mmt_root_path + filename)


def move_compiled_plugin_to_test_folder():
    compiled_path = "C:\\Users\\Administrator\\source\\repos\\mmt-community\\x64\\Release\\"
    test_plugins_path = "C:\\Users\\Administrator\\Desktop\\MMT-Community\\Plugins\\"

    copy_file_name_list = ["MMT.exe", "MMT-Reverse.exe", "MMT-Naraka.exe"]

    for filename in copy_file_name_list:
        shutil.copyfile(compiled_path + filename, test_plugins_path + filename)
        print("Update: " + test_plugins_path + filename)


def deploy_to_release(mmt_version):
    print("Deploy to release:")
    compiled_gui_source_path = "C:\\Users\\Administrator\\source\\repos\\mmt-community\\3Dmigoto-Wheel-GUI\\bin\\Release\\"
    compiled_gui_target_path = "C:\\Users\\Administrator\\Desktop\\MMT-Community-V" + mmt_version + "\\"
    shutil.copyfile(compiled_gui_source_path + "MMT-GUI.exe", compiled_gui_target_path + "MMT-GUI.exe")
    print("Update: " + compiled_gui_target_path + "MMT-GUI.exe")
    compiled_mmt_source_path = "C:\\Users\\Administrator\\source\\repos\\mmt-community\\x64\\Release\\"
    compiled_mmt_target_path = "C:\\Users\\Administrator\\Desktop\\MMT-Community-V" + mmt_version + "\\Plugins\\"
    shutil.copyfile(compiled_mmt_source_path + "MMT.exe", compiled_mmt_target_path + "MMT.exe")
    print("Update: " + compiled_mmt_target_path + "MMT.exe")


# 此脚本用于编译完成后快速移动文件到MMT-Community的Plugins目录里进行测试，以及快速发布
if __name__ == '__main__':
    version_number = "1.0.9.3"
    move_armor_dll_release_to_everygame_folder(version_number)
    print("-----------------------------------------")

    move_all_injector_release_to_everygame_folder(version_number);
    print("-----------------------------------------")

    move_compiled_plugin_to_test_folder()
    print("-----------------------------------------")

    move_compiled_gui_to_test_folder()
    print("-----------------------------------------")

    deploy_to_release(version_number)
    print("-----------------------------------------")

    move_mmt_protect_gui()

