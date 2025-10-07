import os
import shutil
with open('My_intro.txt','w') as f:
    f.write("HI MY NAME IS AIMAN NISAR AND I AM ASPIRING DATA SCIENTIST\n My skill set:Python,JavaScript,R(basics),FastApi,MS Excel(Advanced),MSPOWERBI,EDA,MACHINE LEARNING")

#READING CONTENT
"""with open('My_intro.txt','r') as f:
    line=f.read()
    print(line)"""
#appendubf content
with open('My_intro.txt','a') as f:
    f.write("\n Right now searching and applying for DS INTERNSHIPS")
def read(file_name): #FUNCTIONS CHECKS IF A FILE EXISTS OR NOT AND THEN READING THE CONTENT OGF FILE
    if os.path.exists(file_name):
        with open(file_name,'r') as f:
            line=f.read()
            print(line)
    else:
        print("FILE DOESN;T EXISRS")
read("Ds.txt")
read("My_intro.txt")
shutil.copyfile("My_intro.txt","Aiman_Ds_Cover.txt")

#MERGING TWO FILES
def merge(file1,file2,new_name):
    with open(file1,'r') as f1,open(file2,'r') as f2:
        data=f1.read()
        data2=f2.read()
    with open(new_name,'w') as out:
        out.write(data + "\n")
        out.write(data2)

merge("My_intro.txt","Aiman_Ds_Cover.txt","Final_Ds_Cv.txt")
