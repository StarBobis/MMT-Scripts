import random


def get_insert_str():
    # 创建一个空列表，用于存储子列表
    buf_file_list = []
    
    # 生成随机次数，范围在512到1024之间
    num_elements = random.randint(900, 1000)
    
    # 生成随机数据并添加到 buf_file_list 中
    buf_file_list.extend(random.randint(0, 254) for _ in range(num_elements))

    encrypt_list = "NumList.push_back({"
    for xx in buf_file_list:
        encrypt_list = encrypt_list + str(xx) + ","
    encrypt_list = encrypt_list[:-1]
    encrypt_list = encrypt_list + "});"
    return encrypt_list

def main():
    output_filename = 'C:\\Users\\Administrator\\Desktop\\Key3.txt'
    
    # 打开文件，准备写入
    with open(output_filename, 'w') as file:
        # 循环生成 100 次字符串
        for _ in range(128):
            insert_str = get_insert_str()
            file.write(insert_str + '\n')

if __name__ == "__main__":
    main()