// json2html.js

export default function json2html(data) {
  // Start the table and include the data-user attribute
  let html = `<table data-user="shivashankerreddycheruku@gmail.com">\n<thead>\n<tr>`;

  // Get the column headers dynamically from the object keys in the first object of the array
  const headers = Object.keys(data[0]);
  headers.forEach(header => {
    html += `<th>${header}</th>`;
  });
  
  html += `</tr>\n</thead>\n<tbody>\n`;

  // Loop through each item in the array to build table rows
  data.forEach(row => {
    html += `<tr>`;
    headers.forEach(header => {
      html += `<td>${row[header] || ""}</td>`; // If the property doesn't exist, return an empty cell
    });
    html += `</tr>\n`;
  });

  html += `</tbody>\n</table>`;
  return html;
}
