#include <stdio.h>

int main() {
    int queen[8] = { 0 };  //��������ʺ��λ�� ��queen��ֵ��Ϊ��i�е���
          //queen[0]��ʾ��0��
          //queen[i]��ʾ��i��
    int cnt = 0;   //��ʾ�ڷ��˼����ʺ�Ҳ��ʾ�ڷŻʺ��������
    int col = 0;   //��ʾ����һ���ϰڷ��˻ʺ�
    int sum = 0;   //�ܹ��м��ְڷ�
    while (1) {
        //��(cnt,col)�������ڷŻʺ�

        if (cnt == 1 && queen[0] == 7 && col == 6) {  //��ʾ��һ�еĻʺ��Ѿ����˵ڰ����ҵڶ��еĻʺ��˵�����λ�ã��Ѿ��ڷŲ��»ʺ��˾��˳�ѭ��
            break;
        }
        int isAttack = 0;  //������ʾ�ʺ���֮���Ƿ��ܹ������ĵ�����������ĵ�����1�������Ϊ0
        int i = 0;
        for (i = 0; i < cnt; i++) {
            if (queen[i] == col) { //��ʾ��ͬһ����
                isAttack = 1;
            }
            int div_row = cnt - i;  //��ʾб���ϵ�������֮��
            int div_col = queen[i] - col;  //��ʾб���Ϻ�����֮��
            if (div_row == div_col || div_row == -div_col) {  //��ʾ��ͬһб����
                isAttack = 1;
            }
        }
        if (isAttack == 0) { //��ʾ���Է���
            queen[cnt] = col;  //��¼�ʺ�ǰ������
            cnt++;     //��ʼ�ڷ���һ���ʺ�
            col = 0;    //��һ���ʺ�ӵ�һ�п�ʼ����
            if (cnt == 8) {   //��������˰˸��ʺ�ʹ�ӡ�����ǵİڷ�
                for (i = 0; i < 8; i++) {
                    printf("%d  ", queen[i] + 1);
                }
                printf("\n");
                sum++;    //���Ұڷ�����+1
                do {  //Խ������ //��˷
                    cnt--;  //�������ڰڷŵĻʺ�
                    col = queen[cnt] + 1;  //����һ����Ѱ�Ұڷ�λ��
                } while (col >= 8);
            }
        }
        else {   //��ʾ���ܰڷ�
            col++;
            while (col >= 8) {   //��˷
                cnt--;    //��һ��
                col = queen[cnt] + 1; //��һ���ʺ�������һ��
            }
        }
    }
    printf("�ܹ���%d�ְڷ�\n", sum);
    return 0;
}





