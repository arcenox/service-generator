#!/bin/bash

export LC_CTYPE=UTF-8

read -p "Enter CompanyName: " CompanyName
read -p "Enter ProjectName: " ProjectName
read -p "Enter ServiceName: " ServiceName

NewVal="${CompanyName}.${ProjectName}.${ServiceName}"
AtOldVal="@COMPANYNAME@.@PROJECTNAME@.@SERVICE@"
UnderLineOldVal="_COMPANYNAME_._PROJECTNAME_._SERVICE_"
ServiceDbContext="Service@DbContext"

echo "Started Folder Replacement..."
find . -depth -type d -name "*${AtOldVal}*" | while IFS= read -r x; do
    DIR="$(dirname "${x}")"
    FOLDER="$(basename "${x}")"
    NewFolder="${FOLDER/${AtOldVal}/${NewVal}}"
    mv "$x" "${DIR}/${NewFolder}"
done
echo "--Finished Folder Replacement"

echo "---Started File Replacement..."
find . -type f -name "*${AtOldVal}*" | while IFS= read -r x; do
    DIR="$(dirname "${x}")"
    FILE="$(basename "${x}")"
    NewFile="${FILE/${AtOldVal}/${NewVal}}"
    mv "$x" "${DIR}/${NewFile}"
done

find . -type f -name "*${ServiceDbContext}*" | while IFS= read -r x; do
    DIR="$(dirname "${x}")"
    FILE="$(basename "${x}")"
    NewFile="${FILE/${ServiceDbContext}/${ProjectName}DbContext}"
    mv "$x" "${DIR}/${NewFile}"
done
echo "----Finished File Replacement"

echo "-----Started File Content Replacement..."
find . -type f | while IFS= read -r file; do
    sed -i '' -e "s/${UnderLineOldVal}/${NewVal}/g" "$file"
    sed -i '' -e "s/${AtOldVal}/${NewVal}/g" "$file"
    sed -i '' -e "s/_SERVICE_DbContext/${ProjectName}DbContext/g" "$file"
done
echo "------Finished File Content Replacement"

echo "DONE"
